using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSH_WinForm.controls
{
    public partial class MetroProgressForm : MetroForm
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(MetroProgressForm));
        public DataRowView selectedTask = null;
        public List<DataRowView> selectedHosts = null;
        public List<HostVO> results = null;
        public HealthCheckResultVO healthCheckResultVO = new HealthCheckResultVO();
        public MulitSSH mssh = null;
        public MetroGrid HostGrid {private get; set; } = null;

        public int MaxConnection { get; private set; }

        private MetroProgressForm()
        {
            InitializeComponent();
            this.StyleManager = msmChild;
        }

        public MetroProgressForm(DataRowView taskRow, List<DataRowView> hostRows, MetroGrid grid, int threadCount = 1)
        {
            InitializeComponent();
            this.StyleManager = msmChild;

            selectedTask = taskRow;
            selectedHosts = hostRows;
            HostGrid = grid;

            MaxConnection = (threadCount > 1) ? threadCount : 1;
            MaxConnection = (threadCount < 1) ? 1 : MaxConnection;
        }

        private async void MetroProgressForm_Load(object sender, EventArgs e)
        {
            string taskName = selectedTask["taskName"].ToString();
            string saveDir = Path.GetFullPath(".\\task_result");

            saveDir = Path.Combine(saveDir, taskName, DateTime.Now.ToString("yyyyMMdd"));
            mssh = new MulitSSH(selectedTask, selectedHosts, saveDir);
            mssh.OnProgress += Mssh_OnProgress;
            mssh.OnDataRowViewChange += Mssh_OnDataRowViewChange;
            await mssh.ExecuteAllAsync(MaxConnection);
            Close();
        }

        private void Mssh_OnDataRowViewChange(DataRowView row, string colName, object value)
        {
            try
            {
                if (HostGrid != null && HostGrid.InvokeRequired)
                {
                    HostGrid.Invoke((MethodInvoker)(() =>
                    {
                        if (row != null && row.Row.Table.Columns.Contains(colName) && row[colName] != null)
                        {
                            row[colName] = value;
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                logger.Error("ssh data change error", ex);
            }
        }

        private void Mssh_OnProgress(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (mProgressBar != null && mProgressBar.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        mProgressBar.Value = e.ProgressPercentage;
                    }));
                }
            }
            catch (Exception ex)
            {
                logger.Error("ssh progress error", ex);
            }
        }

        private void MetroProgressForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mssh != null)
            {
                mssh.Stop();
            }
        }
    }
}
