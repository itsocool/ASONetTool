using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MSSH_Library.Comp
{
    public class SSH
    {
        //    private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        //    public bool isComplete = false;
        //    public List<Task<object>> taskList = new List<Task<object>>();
        //    public DataRowView taskRow = null;
        //    public int rowCount = 0;
        //    public CancellationTokenSource ts = new CancellationTokenSource();
        //    //public event EventHandler<SSHEventArgs> OnError;
        //    public event EventHandler<SSHEventArgs> OnWork;
        //    public event EventHandler<EventArgs> OnCompleteAll;
        //    public Dictionary<DataGridViewRow, string> resultMap = new Dictionary<DataGridViewRow, string>();
        //    public Dictionary<DataGridViewRow, string> errorMap = new Dictionary<DataGridViewRow, string>();
        //    public string resultTextDir = null;

        //    public HostVO MultiExecuteSSH(DataRowView taskRow, DataGridViewRow hostRow)
        //    {
        //        //DataGridViewRow row = hostRow;
        //        HostVO vo = new HostVO();
        //        //SshClient Client = null;

        //        //vo.Port = Convert.ToInt32(taskRow["defaultSshPort"]);
        //        //vo.UserId = taskRow["defaultSshId"].ToString();
        //        //vo.UserPassword = taskRow["defaultSshPassword"].ToString();
        //        //vo.ConnectionTimeOut = Convert.ToInt32(taskRow["connectionTimeOut"]);
        //        //vo.CommandList = taskRow["commandList"].ToString();
        //        //vo.Host = row.Cells["host"].Value.ToString();
        //        //vo.Connected = false;
        //        //vo.Athenticated = false;
        //        //vo.Completed = false;
        //        //vo.OnError = false;
        //        //vo.TaskName = taskRow["taskName"].ToString();

        //        //using (Client = new SshClient(vo.Host, vo.Port, vo.UserId, vo.UserPassword))
        //        //{
        //        //    Client.ConnectionInfo.Timeout = new TimeSpan(0, 0, 0, 0, vo.ConnectionTimeOut);
        //        //    //Client.ErrorOccurred += client_ErrorOccurred;

        //        //    logger.Debug("### SSH connecting..... : {0}", vo.Host);
        //        //    row.Cells["progress"].Value = "Connecting";

        //        //    try
        //        //    {
        //        //        Thread.Sleep(100);
        //        //        row.Cells["progress"].Value = "Connecting";
        //        //        row.Cells["connect"].Value = true;
        //        //        logger.Debug("SSH Connect : {0}", vo.Host);

        //        //        Client.Connect();
        //        //        row.Cells["progress"].Value = "login";
        //        //        row.Cells["login"].Value = true;
        //        //        logger.Debug("SSH login : {0}", vo.Host);

        //        //        ShellStream shells = Client.CreateShellStream("test", 80, 24, 800, 600, 1024);

        //        //        List<string> commandList = new List<string>();

        //        //        if (!String.IsNullOrWhiteSpace(vo.CommandList))
        //        //        {
        //        //            string[] commands = vo.CommandList.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        //        //            if (commands != null && commands.Length > 0)
        //        //            {
        //        //                commandList.AddRange(commands);
        //        //            }
        //        //        }

        //        //        vo.Result = "";

        //        //        foreach (var item in commandList)
        //        //        {
        //        //            DateTime s = DateTime.Now;
        //        //            shells.WriteLine(item);

        //        //            if (item.Equals("sh run"))
        //        //            {
        //        //                shells.Flush();
        //        //                vo.Result += shells.Expect(new Regex("^end", RegexOptions.Multiline | RegexOptions.IgnoreCase), new TimeSpan(0, 0, 0, 12));

        //        //                DateTime e = DateTime.Now;
        //        //                TimeSpan ts = e.Subtract(s);
        //        //                logger.Info("sh run {0} : {1}.{2}", vo.Host, ts.Seconds.ToString(), ts.Milliseconds.ToString());
        //        //            }
        //        //            else
        //        //            {
        //        //                shells.Flush();
        //        //                vo.Result += shells.Expect("<{[DUMMY]}>", new TimeSpan(0, 0, 0, 0, 300));
        //        //            }

        //        //            shells.Flush();
        //        //            vo.Result += shells.Read();
        //        //        }

        //        //        if (vo.Result != null && vo.Result.Length > 0)
        //        //        {
        //        //            row.Cells["logText"].Value = vo.Result;
        //        //            ResultSave(row, vo);

        //        //            string equipName = vo.EquipName;
        //        //            string dir = vo.ResultDir;

        //        //            if (string.IsNullOrWhiteSpace(equipName) || string.IsNullOrWhiteSpace(dir))
        //        //            {
        //        //                vo.OnError = true;
        //        //                vo.Error = "no equip name";
        //        //                row.Cells["output"].Value = vo.Error;
        //        //                logger.Error("SSH sh run Exception : {0} {1}", vo.Host, "sh run no equip name");
        //        //            }
        //        //            else
        //        //            {
        //        //                row.Cells["equipName"].Value = equipName;
        //        //            }

        //        //        }
        //        //        else
        //        //        {
        //        //            vo.OnError = true;
        //        //            vo.Error = "ssh result error";
        //        //            row.Cells["output"].Value = vo.Error;
        //        //            logger.Error("SSH Exception : {0} {1}", vo.Host, "ssh result Error");
        //        //        }

        //        //        shells.Close();
        //        //        shells.Dispose();

        //        //    }
        //        //    catch (Exception ex)
        //        //    {
        //        //        logger.Error(ex, vo.Host + " SSH Error");

        //        //        if (!Client.IsConnected)
        //        //        {
        //        //            vo.Connected = false;
        //        //            vo.OnError = true;
        //        //            vo.Error = "Connection Error";
        //        //            row.Cells["connect"].Value = false;
        //        //            row.Cells["output"].Value = vo.Error;
        //        //        }
        //        //        else if (!Client.ConnectionInfo.IsAuthenticated)
        //        //        {
        //        //            vo.Athenticated = false;
        //        //            vo.OnError = true;
        //        //            vo.Error = "Login Error";
        //        //            row.Cells["login"].Value = false;
        //        //            row.Cells["output"].Value = vo.Error;
        //        //        }

        //        //    }
        //        //    finally
        //        //    {
        //        //        vo.Completed = true;
        //        //        row.Cells["complete"].Value = true;
        //        //        logger.Debug("SSH Complete : {0}", vo.Host);

        //        //        if (Client != null && Client.IsConnected)
        //        //        {
        //        //            Client.Disconnect();
        //        //        }
        //        //    }
        //        //}

        //        return vo;
        //    }

        //    static public HostVO ExecuteSSH(DataRowView taskRow, DataGridViewRow hostRow)
        //    {
        //        DataGridViewRow row = hostRow;
        //        HostVO vo = new HostVO();
        //        SshClient Client = null;

        //        vo.Port = Convert.ToInt32(taskRow["defaultSshPort"]);
        //        vo.UserId = taskRow["defaultSshId"].ToString();
        //        vo.UserPassword = taskRow["defaultSshPassword"].ToString();
        //        vo.ConnectionTimeOut = Convert.ToInt32(taskRow["connectionTimeOut"]);
        //        vo.CommandList = taskRow["commandList"].ToString();
        //        vo.Host = row.Cells["host"].Value.ToString();
        //        vo.Connected = false;
        //        vo.Athenticated = false;
        //        vo.Completed = false;
        //        vo.OnError = false;
        //        vo.TaskName = taskRow["taskName"].ToString();
        //        vo.HealthVO = new HealthVO();

        //        using (Client = new SshClient(vo.Host, vo.Port, vo.UserId, vo.UserPassword))
        //        {
        //            Client.ConnectionInfo.Timeout = new TimeSpan(0, 0, 0, 0, vo.ConnectionTimeOut);
        //            logger.Debug("### SSH connecting..... : {0}", vo.Host);

        //            try
        //            {
        //                Thread.Sleep(100);
        //                row.Cells["progress"].Value = "Connecting";
        //                logger.Debug("SSH Connect : {0}", vo.Host);

        //                Client.Connect();
        //                row.Cells["progress"].Value = "login";
        //                logger.Debug("SSH login : {0}", vo.Host);

        //                ShellStream shells = Client.CreateShellStream("test", 80, 24, 800, 600, 1024);

        //                List<string> commandList = new List<string>();

        //                if (!String.IsNullOrWhiteSpace(vo.CommandList))
        //                {
        //                    string[] commands = vo.CommandList.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        //                    if (commands != null && commands.Length > 0)
        //                    {
        //                        commandList.AddRange(commands);
        //                    }
        //                }

        //                vo.Result = "";

        //                row.Cells["progress"].Value = "Execute";

        //                foreach (var item in commandList)
        //                {
        //                    DateTime s = DateTime.Now;
        //                    shells.WriteLine(item);

        //                    if (item.Equals("sh run"))
        //                    {
        //                        shells.Flush();
        //                        vo.Result += shells.Expect(new Regex("^end", RegexOptions.Multiline | RegexOptions.IgnoreCase), new TimeSpan(0, 0, 0, 12));

        //                        DateTime e = DateTime.Now;
        //                        TimeSpan ts = e.Subtract(s);
        //                        logger.Info("sh run {0} : {1}.{2}", vo.Host, ts.Seconds.ToString(), ts.Milliseconds.ToString());
        //                    }
        //                    else
        //                    {
        //                        shells.Flush();
        //                        vo.Result += shells.Expect("<{[DUMMY]}>", new TimeSpan(0, 0, 0, 0, 300));
        //                    }

        //                    shells.Flush();
        //                    vo.Result += shells.Read();
        //                }

        //                if (vo.Result != null && vo.Result.Length > 0)
        //                {
        //                    row.Cells["logText"].Value = vo.Result;
        //                    ResultSave(row, vo);

        //                    string equipName = vo.EquipName;
        //                    string dir = vo.ResultDir;

        //                    if (string.IsNullOrWhiteSpace(equipName) || string.IsNullOrWhiteSpace(dir))
        //                    {
        //                        vo.OnError = true;
        //                        vo.Error = "Failed ";
        //                        row.Cells["output"].Value = vo.Error;
        //                        logger.Error("SSH sh run Exception : {0} {1}", vo.Host, "sh run no equip name");
        //                    }
        //                    else
        //                    {
        //                        vo.OnError = false;
        //                        row.Cells["equipName"].Value = equipName;
        //                        row.Cells["progress"].Value = "Complate";
        //                        row.Cells["output"].Value = "Executed";
        //                        row.Cells["logPath"].Value = dir;
        //                    }

        //                }
        //                else
        //                {
        //                    vo.OnError = true;
        //                    vo.Error = "ssh result error";
        //                    row.Cells["output"].Value = vo.Error;
        //                    logger.Error("SSH Exception : {0} {1}", vo.Host, "ssh result Error");
        //                }

        //                shells.Close();
        //                shells.Dispose();

        //            }
        //            catch (Exception ex)
        //            {
        //                logger.Error(ex, vo.Host + " SSH Error");
        //                row.Cells["progress"].Value = "Error";
        //                vo.OnError = true;

        //                if (!Client.IsConnected)
        //                {
        //                    vo.Connected = false;
        //                    vo.OnError = true;
        //                    vo.Error = "Connection Error";
        //                    row.Cells["output"].Value = vo.Error;
        //                }
        //                else if (!Client.ConnectionInfo.IsAuthenticated)
        //                {
        //                    vo.Athenticated = false;
        //                    vo.OnError = true;
        //                    vo.Error = "Login Error";
        //                    row.Cells["output"].Value = vo.Error;
        //                }

        //            }
        //            finally
        //            {
        //                vo.Completed = true;
        //                row.Cells["onError"].Value = vo.OnError.ToString();
        //                row.Cells["complete"].Value = true.ToString();
        //                logger.Debug("SSH Complete : {0}", vo.Host);

        //                if (Client != null && Client.IsConnected)
        //                {
        //                    Client.Disconnect();
        //                }
        //            }
        //        }

        //        return vo;
        //    }

        //    public void Start(DataRowView taskRow, DataGridViewRowCollection hostRows)
        //    {
        //        isComplete = false;
        //        this.taskRow = taskRow;
        //        this.rowCount = hostRows.Count;

        //        if (hostRows != null && hostRows.Count > 0)
        //        {
        //            for (int i = 0; i < hostRows.Count; i++)
        //            {
        //                try
        //                {
        //                    if (ts.Token.IsCancellationRequested) break;
        //                    DataGridViewRow row = hostRows[i];
        //                    HostVO vo = new HostVO();
        //                    SubWorker worker = new SubWorker();

        //                    vo.Port = Convert.ToInt32(taskRow["defaultSshPort"]);
        //                    vo.UserId = taskRow["defaultSshId"].ToString();
        //                    vo.UserPassword = taskRow["defaultSshPassword"].ToString();
        //                    vo.ConnectionTimeOut = Convert.ToInt32(taskRow["connectionTimeOut"]);
        //                    vo.CommandList = taskRow["commandList"].ToString();
        //                    vo.Host = row.Cells["host"].Value.ToString();

        //                    worker.OnError += worker_OnError;
        //                    worker.OnWork += worker_OnWork;

        //                    logger.Debug("### Task start {0}", vo.Host);
        //                    Task<object> task = Task.Factory.StartNew<object>(
        //                        () => worker.Execute(vo, row, ts.Token), ts.Token);

        //                    taskList.Add(task);
        //                }
        //                catch (Exception ex)
        //                {
        //                    isComplete = true;
        //                    logger.Error(ex, "ssh client exception", null);
        //                }
        //            }
        //        }
        //    }
        //    public void Start(DataRowView taskRow, List<DataGridViewRow> hostRows)
        //    {
        //        HCSummaryVO hvo = new HCSummaryVO();
        //        this.taskRow = taskRow;
        //        this.rowCount = hostRows.Count;

        //        hvo.AllCount = hostRows.Count;
        //        hvo.PassedCount = 0;
        //        hvo.FailedCount = 0;

        //        if (hostRows != null && hostRows.Count > 0)
        //        {
        //            for (int i = 0; i < hostRows.Count; i++)
        //            {
        //                DataGridViewRow row = null;
        //                SubWorker worker = null;
        //                HostVO vo = new HostVO();

        //                try
        //                {
        //                    if (ts.Token.IsCancellationRequested) break;

        //                    row = hostRows[i];
        //                    vo = new HostVO();
        //                    worker = new SubWorker();

        //                    vo.Port = Convert.ToInt32(taskRow["defaultSshPort"]);
        //                    vo.UserId = taskRow["defaultSshId"].ToString();
        //                    vo.UserPassword = taskRow["defaultSshPassword"].ToString();
        //                    vo.ConnectionTimeOut = Convert.ToInt32(taskRow["connectionTimeOut"]);
        //                    vo.CommandList = taskRow["commandList"].ToString();
        //                    vo.Host = row.Cells["host"].Value.ToString();

        //                    worker.OnError += worker_OnError;
        //                    worker.OnWork += worker_OnWork;

        //                    logger.Debug("### Task start {0}", vo.Host);
        //                    row.Cells["progress"].Value = "start";
        //                    Task<object> task = Task.Factory.StartNew<object>(
        //                        () => worker.Execute(vo, row, ts.Token), ts.Token);
        //                    taskList.Add(task);
        //                }
        //                catch (Exception ex)
        //                {
        //                    if(vo != null)
        //                    {
        //                        vo.OnError = true;
        //                        vo.Completed = true;
        //                    }

        //                    if(row != null)
        //                    {
        //                        row.Cells["progress"].Value = "Error";
        //                        row.Cells["output"].Value = ex.Message;
        //                    }

        //                    logger.Error(ex, "ssh client exception");
        //                }
        //            }
        //        }
        //    }

        //    public bool stop()
        //    {
        //        bool result = false;
        //        ts.Cancel();

        //        //foreach (Task<object> item in taskList)
        //        //{
        //        //    item.
        //        //}

        //        return result;
        //    }

        //    void worker_OnWork(object sender, SSHEventArgs e)
        //    {
        //        SSHEventType type = e.EventType;

        //        switch (type)
        //        {
        //            case SSHEventType.Connected:
        //                e.Row.Cells["progress"].Value = "connect";
        //                break;
        //            case SSHEventType.Login:
        //                e.Row.Cells["progress"].Value = "login";
        //                break;
        //            case SSHEventType.Execute:
        //                e.Row.Cells["progress"].Value = "Execute";
        //                break;
        //            case SSHEventType.Complete:
        //                e.Row.Cells["progress"].Value = "complete";
        //                e.Row.Cells["complete"].Value = true;
        //                ResultProcess(e.Row);
        //                GetUserInfo(e.Row);
        //                break;
        //        }

        //        OnWork(this, e);

        //        lock (resultMap)
        //        {
        //            if (type == SSHEventType.Complete)
        //            {
        //                resultMap[e.Row] = e.Row.Cells["logText"].Value.ToString(); ;
        //            }

        //            if (rowCount <= resultMap.Count + errorMap.Count && !isComplete)
        //            {
        //                //Task.WaitAll(taskList.ToArray());
        //                isComplete = true;
        //                OnCompleteAll(this, new EventArgs());
        //            }
        //        }
        //    }

        //    private void ResultProcess(DataGridViewRow dataGridViewRow)
        //    {
        //        try
        //        {
        //            string output = dataGridViewRow.Cells["logText"].Value.ToString();

        //            if (!String.IsNullOrWhiteSpace(output))
        //            {
        //                string taskName = taskRow["taskName"].ToString();
        //                string equipName = StandardConfigParser.ParseHost(output);
        //                string dir = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        //                dir = Path.Combine(dir, "task_result", taskName, DateTime.Now.ToShortDateString());

        //                if (!Directory.Exists(dir))
        //                {
        //                    Directory.CreateDirectory(dir);
        //                }

        //                resultTextDir = dir;

        //                string path = Path.Combine(dir, equipName + ".txt");
        //                using (StreamWriter sw = File.CreateText(path))
        //                {
        //                    logger.Debug("###### File process {0}", dataGridViewRow.Cells["host"].Value);
        //                    sw.Write(output);
        //                }

        //                dataGridViewRow.Cells["equipName"].Value = equipName;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            logger.Debug("###### error {0}, {1}", dataGridViewRow.Cells["host"].Value, ex.Message);
        //        }
        //    }
        //    static private void ResultSave(DataGridViewRow dataGridViewRow, HostVO vo)
        //    {
        //        try
        //        {
        //            string output = vo.Result;

        //            if (!String.IsNullOrWhiteSpace(output))
        //            {
        //                string taskName = vo.TaskName;
        //                string equipName = StandardConfigParser.ParseHost(output);

        //                if (!string.IsNullOrWhiteSpace(equipName))
        //                {
        //                    vo.EquipName = equipName;
        //                    string dir = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        //                    dir = Path.Combine(dir, "task_result", taskName, DateTime.Now.ToShortDateString());

        //                    if (!Directory.Exists(dir))
        //                    {
        //                        Directory.CreateDirectory(dir);
        //                    }

        //                    vo.ResultDir = dir;
        //                    string path = Path.Combine(dir, equipName + ".txt");
        //                    using (StreamWriter sw = File.CreateText(path))
        //                    {
        //                        logger.Debug("###### File process {0}", dataGridViewRow.Cells["host"].Value);
        //                        sw.Write(output);
        //                        vo.ResultFileName = path;
        //                    }

        //                }

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            logger.Debug("###### error {0}, {1}", dataGridViewRow.Cells["host"].Value, ex.Message);
        //        }
        //    }

        //    void worker_OnError(object sender, SSHEventArgs e)
        //    {
        //        SSHEventType type = e.EventType;

        //        switch (type)
        //        {
        //            case SSHEventType.ConnectFail:
        //                e.Row.Cells["output"].Value = "connect fail";
        //                e.Row.Cells["connect"].Value = false;
        //                break;
        //            case SSHEventType.LoginFail:
        //                e.Row.Cells["output"].Value = "login fail";
        //                e.Row.Cells["login"].Value = false;
        //                break;
        //            case SSHEventType.ExecuteFail:
        //                e.Row.Cells["output"].Value = "Execute fail";
        //                break;
        //            case SSHEventType.Error:
        //            default:
        //                e.Row.Cells["output"].Value = "Error";
        //                break;
        //        }
        //        e.Row.Cells["progress"].Value = "Error";
        //        e.Row.Cells["complete"].Value = true;

        //        //OnError(this, e);
        //        lock (errorMap)
        //        {
        //            errorMap[e.Row] = e.Row.Cells["output"].Value.ToString();

        //            if (rowCount <= resultMap.Count + errorMap.Count && !isComplete)
        //            {
        //                isComplete = true;
        //                OnCompleteAll(this, new EventArgs());
        //            }
        //        }

        //    }

        //    public void GetUserInfo(DataGridViewRow dataGridViewRow)
        //    {
        //        string str = dataGridViewRow.Cells["logText"].Value.ToString();
        //        List<UserVO> userList = new List<UserVO>();

        //        if (!string.IsNullOrWhiteSpace(str))
        //        {
        //            string pattern = @"(hostname )(.+)\r?$";

        //            RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Multiline;

        //            foreach (Match match in Regex.Matches(str, pattern, options))
        //            {
        //                //Console.WriteLine("'{0}// found pattern at index {1}", match.Value, match.Index);

        //                foreach (Group item in match.Groups)
        //                {
        //                    string value = item.Value.Trim();
        //                    //Console.WriteLine("'{0}// capture at index {1}", value, item.Index);                                                                        
        //                }

        //            }

        //            pattern = @"(username )(.+)(privilege |password )([0-9]+)( secret | )([0-9]+)(.+)\r?$";

        //            int userCount = 0;

        //            foreach (Match match in Regex.Matches(str, pattern, options))
        //            {
        //                //Console.WriteLine("'{0}// found pattern at index {1}", match.Value, match.Index);

        //                //Console.WriteLine("### {1} {2} {3} {4} {5} {6} {7}", match.Groups[1], match.Groups[2], match.Groups[3], match.Groups[4], match.Groups[5], match.Groups[6], match.Groups[7]);

        //                foreach (Group item in match.Groups)
        //                {
        //                    string value = item.Value.Trim();
        //                    //Console.WriteLine("### {0} ", value);
        //                }

        //                userCount++;
        //            }

        //            dataGridViewRow.Cells["userCount"].Value = userCount;

        //            //if((matches = str.match(/hostname .+/)) && matches.length > 0)
        //            //{
        //            //    hostName = matches[0].toString().replace(/hostname /,"");
        //            //}

        //            //matches = str.match(/username .+ (privilege [0-9]+ secret [0-9]+ .+|password [0-9]+ [0-9]+)/g);

        //            //if(matches)
        //            //{
        //            //    userList = new ArrayCollection();
        //            //    userMap = new Dictionary();

        //            //    for (var i:int = 0; i < matches.length; i++) 
        //            //    {
        //            //        var user:UserVo = new UserVo();
        //            //        var arr:Array = matches[i].split(" ");
        //            //        user.no = i + 1;
        //            //        user.userName = (arr[1]) ? StringUtil.trim(arr[1]) : null;
        //            //        user.privilege = isNaN(parseInt(arr[3])) ? NaN : parseInt(arr[3]);

        //            //        if(arr.length > 5)
        //            //        {
        //            //            user.secret = isNaN(parseInt(arr[5])) ? NaN : parseInt(arr[5]);
        //            //            user.hash =(arr[6]) ? StringUtil.trim(arr[6]) : null;
        //            //        }
        //            //        userMap[user.userName] = user;
        //            //        userList.addItem(user);

        //            //    }
        //            //}

        //            //isComplete = true;
        //        }

        //    }
    }
}
