using MetroFramework;
using MetroFramework.Forms;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MSSH_WinForm.controls
{
    public partial class MetroTaskForm : MetroForm
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(MetroTaskForm));

        public bool IsChanged { get; set; } = false;
        public string SelectedTaskName { get; internal set; }
        public string LastTaskName { get; internal set; }

        #region 기본

        public MetroTaskForm()
        {
            InitializeComponent();
            this.StyleManager = msmChild;

            // TODO: 이 코드는 데이터를 'taskDataSet.task' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.taskTableAdapter.Fill(this.taskDataSet.task);
            // TODO: 이 코드는 데이터를 'taskDataSet.hosts' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.hostsTableAdapter.Fill(this.taskDataSet.hosts);

            Binding bindingAutoExitYN = this.mchkAutoExit.DataBindings[0];
            Binding bindingCommandList = this.mtxtCommand.DataBindings[0];

            if (bindingAutoExitYN != null)
            {
                bindingAutoExitYN.Format += delegate (object obj, ConvertEventArgs arg)
                {
                    arg.Value = (arg.Value != null && arg.Value.ToString() == "Y") ? true : false;
                };

                bindingAutoExitYN.Parse += delegate (object obj, ConvertEventArgs arg)
                {
                    arg.Value = (arg.Value is bool && (bool)(arg.Value) == true) ? "Y" : "N";
                };
            }

            if (bindingCommandList != null)
            {
                bindingCommandList.Format += delegate (object obj, ConvertEventArgs arg)
                {
                    if (!(arg.Value is string)) return;
                    arg.Value = arg.Value.ToString().Replace(Environment.NewLine, "\n").Replace("\n", Environment.NewLine);
                };

                bindingCommandList.Parse += delegate (object obj, ConvertEventArgs arg)
                {
                    if (!(arg.Value is string)) return;
                    arg.Value = arg.Value.ToString().Replace(Environment.NewLine, "\n");
                };
            }

            foreach (DataRowView item in taskBindingSource)
            {
                if (SelectedTaskName == item["taskName"].ToString())
                {
                    taskBindingSource.CurrencyManager.Position = taskBindingSource.List.IndexOf(item);
                    break;
                }
            }
        }

        private void MetroTaskForm_Load(object sender, EventArgs e)
        {
            foreach (DataRowView item in taskBindingSource)
            {
                if (SelectedTaskName == item["taskName"].ToString())
                {
                    taskBindingSource.CurrencyManager.Position = taskBindingSource.List.IndexOf(item);
                    break;
                }
            }
        }

        private void mtbMaxConnections_ValueChanged(object sender, EventArgs e)
        {
            int value = mtbMaxConnections.Value;
            mtxtMaxConnections.Text = value.ToString();
        }

        private void mtbTimeOut_ValueChanged(object sender, EventArgs e)
        {
            int value = mtbTimeOut.Value;
            mtxtTimeOut.Text = value.ToString();
        }

        #endregion

        #region 작업

        private void mbtnTaskAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool dupName = false;
                string newName = "새작업";
                TaskDataSet.taskRow newRow = null;

                dupName = isDupTaskName(newName);

                if (dupName)
                {
                    MetroMessageBox.Show(this, "이미 같은 이름의 작업이 있습니다.");
                    mgrdTask.BeginEdit(true);
                }
                else
                {
                    newRow = taskDataSet.task.AddtaskRow(
                        newName
                        , "."
                        , "sshId"
                        , "sshPwd"
                        , "21"
                        , "Y"
                        , 1
                        , 3
                        , "exit"
                        , ""
                        , null
                        , null
                        );
                    taskTableAdapter.Update(newRow);
                    using (TaskDataSet.taskDataTable taskTable = taskTableAdapter.GetData())
                    {
                        foreach (TaskDataSet.taskRow task in taskTable.Rows)
                        {
                            if (task["taskName"] != null && newRow["taskName"].ToString() == task["taskName"].ToString())
                            {
                                newRow["taskId"] = task["taskId"];
                                newRow.AcceptChanges();
                                break;
                            }
                        }
                    }

                    Validate();
                    taskBindingSource.EndEdit();
                    taskBindingSource.MoveLast();
                    mgrdTask.BeginEdit(true);
                }
            }
            catch (Exception ex)
            {
                logger.Error("새작업 추가 에러", ex);
            }
        }

        private void mgrdTask_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            logger.Debug(e.Context.ToString());
        }

        private void mbtnTaskRename_Click(object sender, EventArgs e)
        {
            if (taskBindingSource.Count > 0 && taskBindingSource.Current != null)
            {
                mgrdTask.BeginEdit(true);
            }
            else
            {
                MetroMessageBox.Show(this, "데이타가 없습니다.");
            }
        }

        private void mbtnTaskDelete_Click(object sender, EventArgs e)
        {
            if (taskBindingSource.Count > 0 && taskBindingSource.Current is DataRowView)
            {
                DataRowView rowView = taskBindingSource.Current as DataRowView;
                rowView.Row.Delete();
                this.Validate();
                this.hostsBindingSource.EndEdit();
                this.taskBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.taskDataSet);
            }
            else
            {
                MetroMessageBox.Show(this, "데이타가 없습니다.");
            }
        }

        private void mbtnTaskCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (taskBindingSource.Count > 0 && taskBindingSource.Current is DataRowView)
                {
                    DataRowView currentRowView = taskBindingSource.Current as DataRowView;
                    TaskDataSet.taskRow currentTaskRow = currentRowView.Row as TaskDataSet.taskRow;
                    TaskDataSet.taskDataTable taskTable = currentTaskRow.Table as TaskDataSet.taskDataTable;
                    string newName = currentTaskRow.taskName + "의 복사본";
                    bool isDupName = isDupTaskName(newName);

                    if (isDupName)
                    {
                        MetroMessageBox.Show(this, "[" + newName + "] 같은 이름의 작업이 이미 있습니다.");
                    }
                    else
                    {
                        List<string> hostList = new List<string>();

                        foreach (DataRowView item in hostsBindingSource.List)
                        {
                            hostList.Add(item["host"].ToString());
                        }

                        TaskDataSet.taskRow newTaskRow = taskTable.AddtaskRow(
                            newName
                            , currentTaskRow.workingDir
                            , currentTaskRow.defaultSshId
                            , currentTaskRow.defaultSshPassword
                            , currentTaskRow.defaultSshPort
                            , currentTaskRow.autoExitYN
                            , currentTaskRow.maxConnections
                            , currentTaskRow.connectionTimeOut
                            , currentTaskRow.commandList
                            , currentTaskRow.remark
                            , null
                            , null
                            );
                        taskTableAdapter.Update(newTaskRow);

                        using (TaskDataSet.taskDataTable newTaskTable = taskTableAdapter.GetData())
                        {
                            foreach (TaskDataSet.taskRow task in newTaskTable.Rows)
                            {
                                if (task["taskName"] != null && newTaskRow["taskName"].ToString() == task["taskName"].ToString())
                                {
                                    newTaskRow["taskId"] = task["taskId"];
                                    newTaskRow.AcceptChanges();
                                    break;
                                }
                            }
                        }

                        Validate();
                        taskBindingSource.EndEdit();
                        taskBindingSource.MoveLast();

                        if (hostList.Count > 0)
                        {
                            foreach (string host in hostList)
                            {
                                DataRowView newHost = hostsBindingSource.AddNew() as DataRowView;
                                newHost["host"] = host;
                            }

                            hostsBindingSource.EndEdit();
                        }
                        mgrdTask.BeginEdit(true);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "데이타가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                logger.Error("작업 복사 에러", ex);
            }
        }

        private bool isDupTaskName(string taskName)
        {
            bool result = false;

            if (taskBindingSource.Count > 0)
            {
                foreach (DataRowView row in taskBindingSource)
                {
                    if (row["taskName"] != null && row["taskName"].ToString() == taskName)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        #endregion

        #region 호스트

        private void mbtnHostDelete_Click(object sender, EventArgs e)
        {
            if (hostsBindingSource.Count > 0 && hostsBindingSource.Current is DataRowView)
            {
                DataRowView rowView = hostsBindingSource.Current as DataRowView;
                rowView.Row.Delete();
                this.Validate();
                this.hostsBindingSource.EndEdit();
                this.hostsTableAdapter.Update(taskDataSet.hosts);
            }
            else
            {
                MetroMessageBox.Show(this, "데이타가 없습니다.");
            }
        }

        private void mbtnHostImport_Click(object sender, EventArgs e)
        {
            if (taskBindingSource.Current != null)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Multiselect = false;
                    dialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    dialog.Filter = "Excel (*.xlsx;*.xls)|*.xlsx;*.xls|AllFiles(*.*)|*.*";
                    dialog.Title = "호스트 목록을 가져올 엑셀 파일을 선택해 주십시오";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        ImportExcel(dialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    logger.Error("exlcel import error", ex);

                }
            }
            else
            {
                MetroMessageBox.Show(this, "선택한 작업 데이타가 없습니다.");
            }
        }

        private void mbtnHostExport_Click(object sender, EventArgs e)
        {
            if (taskBindingSource.Current != null && hostsBindingSource.Count > 0 && hostsBindingSource.Current is DataRowView)
            {
                try
                {
                    string exportDir = Properties.Settings.Default.APP_DIR;
                    exportDir = string.IsNullOrWhiteSpace(exportDir) ? "exports" : exportDir;
                    exportDir = Path.GetFullPath(exportDir);
                    exportDir = Path.GetDirectoryName(exportDir);
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.InitialDirectory = exportDir;
                    dialog.Filter = "Excel (*.xlsx;*.xls)|*.xlsx;*.xls|AllFiles(*.*)|*.*";
                    dialog.Title = "호스트 목록을 가져올 엑셀 파일을 선택해 주십시오";
                    dialog.FileName = "host_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".xls";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        IWorkbook wb = ExcelHelper.exportExcel(mgrdHost, dialog.FileName);

                        using (FileStream stream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            wb.Write(stream);
                        }

                        MetroMessageBox.Show(this, dialog.FileName + " 저장 완료");
                    }
                }
                catch (Exception ex)
                {
                    logger.Error("host excel export error", ex);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "데이타가 없습니다.");
            }
        }

        private void mgrdHost_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = e.Data.GetData(DataFormats.FileDrop, false) as string[];

                if (fileNames != null && !string.IsNullOrWhiteSpace(fileNames[0]))
                {
                    string ext = Path.GetExtension(fileNames[0]);
                    if (ext.ToLower() == ".xls" || ext.ToLower() == ".xlsx")
                    {
                        ImportExcel(fileNames[0]);
                        return;
                    }
                }

                MetroMessageBox.Show(this, "한개의 Excel 파일만 가능 합니다.");
            }
        }

        private void mgrdHost_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = e.Data.GetData(DataFormats.FileDrop, false) as string[];

                if (fileNames != null && !string.IsNullOrWhiteSpace(fileNames[0]))
                {
                    string ext = Path.GetExtension(fileNames[0]);
                    if (ext.ToLower() == ".xls" || ext.ToLower() == ".xlsx")
                    {
                        e.Effect = DragDropEffects.All;
                        return;
                    }
                }
            }

            e.Effect = DragDropEffects.None;
        }

        private void mgrdHost_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    DataRowView task = taskBindingSource.Current as DataRowView;

                    if(task != null && task["taskName"] != null && !string.IsNullOrWhiteSpace(task["taskName"].ToString()))
                    {
                        string hostValue = mgrdHost[e.ColumnIndex, e.RowIndex].Value.ToString();
                        bool dupValue = isDupHost(hostValue, mgrdHost.Rows[e.RowIndex]);

                        if (dupValue)
                        {
                            MetroMessageBox.Show(this, "중복 호스트 입니다.");
                            mgrdHost[e.RowIndex, e.ColumnIndex].ErrorText = "중복  dup !!!";
                            e.Cancel = true;
                            mgrdHost.BeginEdit(true);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "작업명이 없습니다. 작업명을 먼저 입력 하세요.");
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("호스트 중복 검사오류", ex);
            }
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hostsBindingSource.EndEdit();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taskDataSet);

            IsChanged = true;
            MetroMessageBox.Show(this, "저장 되었습니다.");
            Close();
        }

        private void ImportExcel(string fileName)
        {
            DataSet ds = ExcelHelper.importExcel(fileName);
            Dictionary<string, bool> uinqueRows = new Dictionary<string, bool>();
            int idx = 0;

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0] == null)
            {
                MetroMessageBox.Show(this, "읽어온 데이타가 없습니다.");
                return;
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                bool isDup = false;
                string host = row[0].ToString();

                isDup = isDupHost(host);

                if (!isDup)
                {
                    uinqueRows[host] = isDup;
                }
            }

            foreach (string item in uinqueRows.Keys)
            {
                DataRowView newRow = hostsBindingSource.AddNew() as DataRowView;

                if (newRow != null && !string.IsNullOrWhiteSpace(item))
                {
                    newRow["host"] = item;
                    idx++;
                }
            }

            hostsBindingSource.MoveLast();
            MessageBox.Show(idx.ToString() + "개의 새로운 호스트가 추가되었습니다.\r\n저장 하시려면 저장버튼을 눌러주세요");
        }

        private bool isDupHost(string host, DataGridViewRow curRow = null)
        {
            bool result = false;

            if (mgrdHost.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in mgrdHost.Rows)
                {
                    if (row.Cells != null && row.Cells.Count > 0 && curRow != row)
                    {
                        DataGridViewCell cell = row.Cells[0];
                        if (cell != null && cell.Value != null && cell.Value.ToString() == host)
                        {
                            result = true;
                            break;
                        }

                    }
                }
            }
            return result;
        }

        private void mbtnEelAll_Click(object sender, EventArgs e)
        {
            if (hostsBindingSource.Count > 0 && MetroMessageBox.Show(this, "모든 호스트를 삭제 하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var item in hostsBindingSource)
                {
                    hostsBindingSource.RemoveCurrent();
                }

                this.Validate();
                this.hostsBindingSource.EndEdit();
                this.hostsTableAdapter.Update(taskDataSet.hosts);
            }
            else
            {
                MetroMessageBox.Show(this, "데이타가 없습니다.");
            }
        }

        private void MetroTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LastTaskName = (taskBindingSource.Current != null) ? (taskBindingSource.Current as DataRowView)["taskName"].ToString() : null;
        }

        private void hostsBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            logger.Error("호스트 바인딩 데이타 에러", e.Exception);
        }

        private void taskBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            logger.Error("작업 바인딩 데이타 에러", e.Exception);
        }

        #endregion

    }
}
