using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Schedulers;

namespace MSSH_Library.Comp
{
    public class MSSHWorker : IDisposable
    {
        static private NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private List<DataRowView> selectedRows;
        private DataRowView selectedTask;
        //private List<Task> taskList = null;
        //private int maxWorkerCount = 1;

        public MSSHWorker(DataRowView selectedTask, List<DataRowView> selectedRows)
        {
            this.selectedTask = selectedTask;
            this.selectedRows = selectedRows;
        }

        public void Dispose()
        {
            logger.Debug("MSSHWorker disposed");
        }

        public void Start(int count)
        {

            Parallel.For(0, 10, (i, loopState) => 
            {
                Console.WriteLine(i + " #1: " + DateTime.Now.ToFileTime());
                Thread.Sleep(1000);
                Console.WriteLine(i + " #2: " + DateTime.Now.ToFileTime());
                Thread.Sleep(1000);
                Console.WriteLine(i + " #3: " + DateTime.Now.ToFileTime());
                Thread.Sleep(1000);
                Console.WriteLine(i + " #4: " + DateTime.Now.ToFileTime());
                //log.Debug("####");
            });

            //maxWorkerCount = (count < 1) ? 1 : count;

            //StaTaskScheduler scheduler = new StaTaskScheduler(4);
            //taskList = new List<Task>();
            //TaskFactory factory = new TaskFactory(scheduler);
            //CancellationTokenSource cts = new CancellationTokenSource();

            //for (int i = 0; i < selectedRows.Count; i++)
            //{
            //    Task task = factory.StartNew(() => {
            //        logger.Debug(selectedRows[i]["host"].ToString());
            //    }, cts.Token);

            //    taskList.Add(task);
            //}

            //Task.WaitAll(taskList.ToArray());
            //cts.Dispose();
            //logger.Debug("Successful completion.");

            //if (maxWorkerCount == 1)
            //{

            //}else
            //{

            //}
        }
    }
}
