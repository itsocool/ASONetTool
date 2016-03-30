using Renci.SshNet;
using Renci.SshNet.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MSSH_WinForm.controls
{
    public class MulitSSH
    {
        #region Main
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(MulitSSH));
        private CancellationTokenSource cts = null;
        private ParallelOptions po = null;
        private int progressPercent = 0;
        private int completeCount = 0;
        private int totalCount = 0;

        public event EventHandler<ProgressChangedEventArgs> OnProgress;
        public event Action<DataRowView, string, object > OnDataRowViewChange;
        //public event EventHandler<DataRowChangeEventArgs> OnCompleted;

        public DataRowView TaskRow { get; private set; } = null;
        public List<DataRowView> HostRows { get; private set; } = null;

        public string SaveDir { get; set; }
        public int MaxConnection { get; private set; }

        public MulitSSH(DataRowView taskRow, List<DataRowView> hostRows, string saveDir)
        {
            TaskRow = taskRow;
            HostRows = hostRows;
            SaveDir = saveDir;
            totalCount = hostRows.Count;
        }
        #endregion

        #region SSH 처리

        private void SetValue(DataRowView row, string colName, object value)
        {
            if (OnDataRowViewChange != null)
            {
                OnDataRowViewChange(row, colName, value);
            }
        }

        public void Execute(DataRowView task, DataRowView host)
        {
            string result = "";
            string logPath = null;

            try
            {
                SetValue(host, "progress", ProgressSate.Ready.ToString());

                if (po.CancellationToken.CanBeCanceled)
                {
                    po.CancellationToken.ThrowIfCancellationRequested();
                }

                int port = Convert.ToInt32(task["defaultSshPort"]);
                string userId = task["defaultSshId"].ToString();
                string userPassword = task["defaultSshPassword"].ToString();
                int connectionTimeOut = Convert.ToInt32(task["connectionTimeOut"]);
                string commandList = task["commandList"].ToString();
                string ip = host["host"].ToString();

                using (SshClient client = new SshClient(ip, port, userId, userPassword))
                {
                    SetValue(host, "progress", ProgressSate.Connecting.ToString());
                    client.ConnectionInfo.Timeout = TimeSpan.FromSeconds(connectionTimeOut);
                    client.Connect();
                    SetValue(host, "progress", ProgressSate.Login.ToString());

                    using (ShellStream shellStream = client.CreateShellStream("mssh", 80, 24, 800, 600, 32 * 1024))
                    {
                        string[] commands = (string.IsNullOrWhiteSpace(commandList)) ? null : commandList.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                        SetValue(host, "progress", ProgressSate.Execute.ToString());
                        StringBuilder sb = new StringBuilder(32 * 1024);

                        foreach (var command in commands)
                        {
                            int delay = (command.Trim() == "sh run") ? 15 : 1;
                            int sleep = (command.Trim() == "sh run") ? 1000 : 100;

                            shellStream.WriteLine(command);
                            Thread.Sleep(sleep);
                            sb.Append(shellStream.Expect(new Regex(@"^.+(\$|#)$", RegexOptions.Multiline), TimeSpan.FromSeconds(delay)));
                        }

                        result = sb.ToString();
                        sb.Clear();
                        sb = null;
                        shellStream.WriteLine("exit");
                        logger.InfoFormat("sh run {0} : {1}chars", host, result.Length);
                    }
                }

                if (!string.IsNullOrWhiteSpace(result))
                {
                    SetValue(host, "progress", ProgressSate.Parsing.ToString());
                    string equipName = StandardConfigParser.ParseHost(result);

                    if (!string.IsNullOrWhiteSpace(equipName))
                    {
                        SetValue(host, "equipName", equipName);
                        SetValue(host, "progress", ProgressSate.SaveFile.ToString());

                        if (!Directory.Exists(SaveDir))
                        {
                            Directory.CreateDirectory(SaveDir);
                        }

                        logPath = Path.Combine(SaveDir, equipName + ".txt");

                        using (StreamWriter sw = File.CreateText(logPath))
                        {
                            sw.Write(result);
                        }

                        if (File.Exists(logPath))
                        {
                            SetValue(host, "onError", false);
                            SetValue(host, "logPath", logPath);
                            SetValue(host, "logText", result);
                            SetValue(host, "output", "로그파일 저장 완료");
                        }
                        else
                        {
                            SetValue(host, "onError", true);
                            SetValue(host, "output", "SSH 로그 파일 저장 에러");
                        }
                    }
                    else
                    {
                        SetValue(host, "onError", true);
                        SetValue(host, "output", "SSH 로그 파일 분석 결과 에러");
                    }
                }
                else
                {
                    SetValue(host, "onError", true);
                    SetValue(host, "output", "SSH 실행 결과 에러");
                }
            }
            catch (SshConnectionException ex)
            {
                SetValue(host, "onError", true);
                SetValue(host, "output", "SSH 접속 에러:" + ex.Message);
                logger.Error("ssh error", ex);
            }
            catch (SshAuthenticationException ex)
            {
                SetValue(host, "onError", true);
                SetValue(host, "output", "SSH 로그인 에러:" + ex.Message);
                logger.Error("ssh error", ex);
            }
            catch (Exception ex)
            {
                if(host["onError"].ToString() != bool.TrueString)
                {
                    SetValue(host, "onError", true);
                    SetValue(host, "output", "SSH 에러:" + ex.Message);
                    logger.Error("ssh error", ex);
                }
            }finally
            {
                if(host["onError"].ToString() != bool.TrueString)
                {
                    SetValue(host, "onError", false);
                    SetValue(host, "complete", true);
                }

                if(OnProgress != null)
                {
                    Interlocked.Increment(ref completeCount);
                    progressPercent = (completeCount * 100) / totalCount;
                    ProgressChangedEventArgs e = new ProgressChangedEventArgs(progressPercent, null);
                    OnProgress(this, e);
                }
            }

            //return result;
        }

        public void ExecuteAll()
        {
            try
            {
                cts = new CancellationTokenSource();
                po = new ParallelOptions();
                po.CancellationToken = cts.Token;
                po.MaxDegreeOfParallelism = MaxConnection;

                Parallel.ForEach(HostRows, po, (host) =>
                {
                    try
                    {
                        Thread.Sleep(100);
                        Execute(TaskRow, host);
                    }
                    catch (Exception ex)
                    {
                        logger.Error("ExecuteAll loop error", ex);
                    }finally
                    {
                        //Complete(host);
                    }
                });
            }
            catch(OperationCanceledException ex)
            {
                logger.Error("ssh loop cancel error", ex);
            }
            catch (Exception ex)
            {
                logger.Error("ssh loop error", ex);
            }
        }

        public void ExecuteAll(int maxConnection)
        {
            MaxConnection = maxConnection;
            ExecuteAll();
        }

        public Task ExecuteAllAsync()
        {
            var task = Task.Run(() => ExecuteAll());
            return task;
        }

        public Task ExecuteAllAsync(int maxConnection)
        {
            var task = Task.Run(() => ExecuteAll(maxConnection));
            return task;
        }

        public void Stop()
        {
            cts.Cancel();
        }

        #endregion

    }

    public enum ProgressSate { Ready, Connecting, Login, Execute, Parsing, SaveFile }
}
