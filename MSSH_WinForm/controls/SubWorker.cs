using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace MSSH_WinForm.controls
{
    public class SubWorker
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(SubWorker));
        private SshClient Client {get; set;}
        public DataGridViewRow Row { get; set; }
        public event EventHandler<SSHEventArgs> OnError;
        public event EventHandler<SSHEventArgs> OnWork;
        public CancellationToken Token { get; set; }
        private bool isComplete = false;

        //public event EventHandler<SSHEventArgs> OnConnect;
        //public event EventHandler<SSHEventArgs> OnAuthenticate;
        //public event EventHandler<SSHEventArgs> OnResult;
        //public event EventHandler<SSHEventArgs> OnComplete;

        public object Execute(HostVO hostVO, DataGridViewRow row, CancellationToken token)
        {
            Row = row;
            Token = token;

            using (Client = new SshClient(hostVO.Host, hostVO.Port, hostVO.UserId, hostVO.UserPassword))
            {
                Client.ConnectionInfo.Timeout = new TimeSpan(0, 0, 0, 0, hostVO.ConnectionTimeOut);
                Client.ErrorOccurred += client_ErrorOccurred;

                logger.DebugFormat("### SSH connecting..... : {0}", hostVO.Host);
                if (Token.IsCancellationRequested) return null;
                SSHEventArgs executeArgs = new SSHEventArgs(SSHEventType.Connected, "Connect!", Client, Row);
                OnWork(this, executeArgs);
                logger.DebugFormat("SSH Connect : {0}", hostVO.Host);

                try
                {

                    Thread.Sleep(100);
                    Row.Cells["progress"].Value = "login";
                    Client.Connect();

                    SSHEventArgs loginArgs = new SSHEventArgs(SSHEventType.Login, "login!", Client, Row);
                    OnWork(this, loginArgs);
                    logger.DebugFormat("SSH login : {0}", hostVO.Host);



                    ////

                    ShellStream shells = Client.CreateShellStream("test", 80, 24, 800, 600, 1024);
                    List<string> commandList = getCommandList(hostVO.CommandList);
                    string result = null;


                    foreach (var item in commandList)
                    {

                        shells.WriteLine(item);

                        TimeSpan timeSpan;

                        if (item.Equals("sh run"))
                        {
                            timeSpan = new TimeSpan(0, 0, 0, 0, 3000);
                            shells.Expect(new Regex("^end$", RegexOptions.Singleline | RegexOptions.IgnoreCase), timeSpan);
                        }
                        else
                        {
                            timeSpan = new TimeSpan(0, 0, 0, 0, 500);
                            shells.Expect("<{[DUMMY]}>", timeSpan);
                        }

                        result += shells.Read();
                    }

                    isComplete = true;
                    
                    if (result != null && result.Length > 0)
                    {
                        lock (row)
                        {
                            row.Cells["output"].Value = hostVO.Host + " " + row.Cells["host"].Value.ToString() + " " + result;
                        }

                        isComplete = true;
                        SSHEventArgs comleteArgs = new SSHEventArgs(SSHEventType.Complete, "Complete!", Client, Row);
                        OnWork(this, comleteArgs);
                        logger.DebugFormat("SSH Complete : {0}", hostVO.Host);
                    }else
                    {
                        SSHEventArgs sshe = new SSHEventArgs(SSHEventType.ExecuteFail, "Execute Error!", Client, Row);
                        OnError(this, sshe);
                        logger.ErrorFormat("SSH Exception : {0} {1}", hostVO.Host, "Excuete Error");
                    }

                    shells.Close();
                    shells.Dispose();

                }
                catch (Exception ex)
                {
                    logger.Error( hostVO.Host + "SSH Exception : {0} {1}", ex);

                    if(!isComplete)
                    {
                        SSHEventArgs sshe = null;

                        if (Client.IsConnected && !Client.ConnectionInfo.IsAuthenticated)
                        {
                            sshe = new SSHEventArgs(SSHEventType.LoginFail, "login Error!", Client, Row);
                        }
                        else
                        {
                            sshe = new SSHEventArgs(SSHEventType.ConnectFail, "Connec Error!", Client, Row);
                        }

                        isComplete = true;
                        OnError(this, sshe);
                        
                    }
                }

                //if(Client != null && Client.IsConnected && Client.ConnectionInfo != null && Client.ConnectionInfo.IsAuthenticated)
                //{
                //    try
                //    {
                //        SSHEventArgs loginArgs = new SSHEventArgs(SSHEventType.Login, "login!", Client, Row);
                //        OnWork(this, loginArgs);
                //        logger.DebugFormat("SSH login : {0}", hostVO.Host);

                //        string results = "";
                //        List<string> commandList = getCommandList(hostVO.CommandList);
                //        shells = Client.CreateShellStream("test", 80, 24, 800, 600, 1024);
                //        Row.Cells["progress"].Value = "execute";

                //        foreach (string command in commandList)
                //        {
                //            if (Token.IsCancellationRequested) return null;
                //            shells.WriteLine(command);
                //            Thread.Sleep(100);
                //            shells.Expect("<<MAGIC_STRING>>", new TimeSpan(0, 0, 0, 0, 1600));
                //            string result = shells.Read();
                //            results += result + Environment.NewLine;
                //            SSHEventArgs executeArgs = new SSHEventArgs(SSHEventType.Execute, "Execute!", Client, Row);
                //            OnWork(this, executeArgs);
                //            logger.DebugFormat("#### host:{0}, command:{1}, result:{2}", hostVO.Host, command, result);
                //        }

                //        logger.Info("SSH Result : {0} {1}", hostVO.Host, results);

                //        lock (row)
                //        {
                //            row.Cells["output"].Value = hostVO.Host + " " + row.Cells["host"].Value.ToString() + " " + results;
                //        }

                //        SSHEventArgs comleteArgs = new SSHEventArgs(SSHEventType.Complete, "Complete!", Client, Row);
                //        OnWork(this, comleteArgs);
                //        logger.DebugFormat("SSH Complete : {0}", hostVO.Host);
                //    }
                //    catch (Exception ex)
                //    {
                //        if(!isComplete)
                //        {
                //            SSHEventArgs sshe = new SSHEventArgs(SSHEventType.ExecuteFail, "Execute Error!", Client, Row);
                //            OnError(this, sshe);
                //            isComplete = true;
                //            logger.Error("SSH Exception : {0} {1}", hostVO.Host, ex.Message);
                //        }
                //    }
                //}
            }

            return null;
        }

        private void client_ErrorOccurred(object sender, Renci.SshNet.Common.ExceptionEventArgs e)
        {
            if(!isComplete)
            {
                SSHEventArgs sshe = new SSHEventArgs(SSHEventType.Error, e.Exception.Message, Client, Row);
                OnError(this, sshe);
                isComplete = true;
                logger.DebugFormat("SSH Error : {0}", e.Exception.Message);
            }
        }

        private List<string> getCommandList(string command)
        {
            List<string> commandList = new List<string>();

            if(!String.IsNullOrWhiteSpace(command))
            {
                string[] separator = new string[]{"\r\n", "\n"};
                string[] commands = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if(commands != null && commands.Length > 0)
                {
                    commandList.AddRange(commands);
                }
            }

            return commandList;
        }

        private void OnRaiseEvent(SSHEventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of 
            // a race condition if the last subscriber unsubscribes 
            // immediately after the null check and before the event is raised.
            EventHandler<SSHEventArgs> handler = OnError;

            // Event will be null if there are no subscribers 
            if (handler != null)
            {
                // Format the string to send inside the CustomEventArgs parameter
                e.Message += String.Format(" at {0}", DateTime.Now.Millisecond);

                // Use the () operator to raise the event.
                handler(this, e);
            }
        }

    }

    public enum SSHEventType { Connected, Login, Execute, Complete, ConnectFail, LoginFail, ExecuteFail, Error };

    public class SSHEventArgs : EventArgs
    {

        public SSHEventArgs(SSHEventType type, object message, SshClient client, DataGridViewRow row)
        {
            EventType = type;
            Message = message;
            Client = client;
            Row = row;
        }

        public SSHEventType EventType { get; set; }

        public object Message { get; set; }

        public SshClient Client { get; set; }
        public DataGridViewRow Row { get; set; }
    }
}
