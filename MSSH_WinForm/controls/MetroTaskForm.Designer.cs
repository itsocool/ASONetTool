namespace MSSH_WinForm.controls
{
    partial class MetroTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroTaskForm));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.mlblTaskList = new MetroFramework.Controls.MetroLabel();
            this.msmChild = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mgrdTask = new MetroFramework.Controls.MetroGrid();
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskDataSet = new MSSH_WinForm.controls.TaskDataSet();
            this.mbtnTaskDelete = new MetroFramework.Controls.MetroButton();
            this.mbtnTaskCopy = new MetroFramework.Controls.MetroButton();
            this.mbtnTaskRename = new MetroFramework.Controls.MetroButton();
            this.mbtnTaskAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mgrdHost = new MetroFramework.Controls.MetroGrid();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onErrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.mbtnDelAll = new MetroFramework.Controls.MetroButton();
            this.mbtnHostDelete = new MetroFramework.Controls.MetroButton();
            this.mbtnHostExport = new MetroFramework.Controls.MetroButton();
            this.mbtnHostImport = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtUserId = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUserPassword = new MetroFramework.Controls.MetroTextBox();
            this.mchkAutoExit = new MetroFramework.Controls.MetroCheckBox();
            this.mtxtPort = new MetroFramework.Controls.MetroTextBox();
            this.mtbMaxConnections = new MetroFramework.Controls.MetroTrackBar();
            this.mtbTimeOut = new MetroFramework.Controls.MetroTrackBar();
            this.mtxtCommand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mtxtMaxConnections = new MetroFramework.Controls.MetroTextBox();
            this.mtxtTimeOut = new MetroFramework.Controls.MetroTextBox();
            this.taskTableAdapter = new MSSH_WinForm.controls.TaskDataSetTableAdapters.taskTableAdapter();
            this.hostsTableAdapter = new MSSH_WinForm.controls.TaskDataSetTableAdapters.hostsTableAdapter();
            this.tableAdapterManager = new MSSH_WinForm.controls.TaskDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 127);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 23;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(240, 272);
            this.metroGrid1.TabIndex = 0;
            // 
            // mlblTaskList
            // 
            this.mlblTaskList.AutoSize = true;
            this.mlblTaskList.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblTaskList.Location = new System.Drawing.Point(24, 64);
            this.mlblTaskList.Name = "mlblTaskList";
            this.mlblTaskList.Size = new System.Drawing.Size(65, 19);
            this.mlblTaskList.TabIndex = 1;
            this.mlblTaskList.Text = "작업목록";
            // 
            // msmChild
            // 
            this.msmChild.Owner = this;
            // 
            // mgrdTask
            // 
            this.mgrdTask.AllowUserToAddRows = false;
            this.mgrdTask.AllowUserToDeleteRows = false;
            this.mgrdTask.AllowUserToResizeRows = false;
            this.mgrdTask.AutoGenerateColumns = false;
            this.mgrdTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgrdTask.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgrdTask.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgrdTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgrdTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIdDataGridViewTextBoxColumn,
            this.taskNameDataGridViewTextBoxColumn});
            this.mgrdTask.DataSource = this.taskBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgrdTask.DefaultCellStyle = dataGridViewCellStyle8;
            this.mgrdTask.EnableHeadersVisualStyles = false;
            this.mgrdTask.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgrdTask.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdTask.Location = new System.Drawing.Point(23, 86);
            this.mgrdTask.Name = "mgrdTask";
            this.mgrdTask.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdTask.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mgrdTask.RowHeadersVisible = false;
            this.mgrdTask.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgrdTask.RowTemplate.Height = 23;
            this.mgrdTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgrdTask.Size = new System.Drawing.Size(156, 369);
            this.mgrdTask.TabIndex = 2;
            this.mgrdTask.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.mgrdTask_DataError);
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "taskId";
            this.taskIdDataGridViewTextBoxColumn.FillWeight = 60F;
            this.taskIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            this.taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.taskIdDataGridViewTextBoxColumn.Visible = false;
            this.taskIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "taskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "작업명";
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            this.taskNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "task";
            this.taskBindingSource.DataSource = this.taskDataSet;
            this.taskBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.taskBindingSource_DataError);
            // 
            // taskDataSet
            // 
            this.taskDataSet.DataSetName = "TaskDataSet";
            this.taskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mbtnTaskDelete
            // 
            this.mbtnTaskDelete.Location = new System.Drawing.Point(23, 490);
            this.mbtnTaskDelete.Name = "mbtnTaskDelete";
            this.mbtnTaskDelete.Size = new System.Drawing.Size(75, 23);
            this.mbtnTaskDelete.TabIndex = 3;
            this.mbtnTaskDelete.Text = "삭제";
            this.mbtnTaskDelete.UseSelectable = true;
            this.mbtnTaskDelete.Click += new System.EventHandler(this.mbtnTaskDelete_Click);
            // 
            // mbtnTaskCopy
            // 
            this.mbtnTaskCopy.Location = new System.Drawing.Point(104, 490);
            this.mbtnTaskCopy.Name = "mbtnTaskCopy";
            this.mbtnTaskCopy.Size = new System.Drawing.Size(75, 23);
            this.mbtnTaskCopy.TabIndex = 4;
            this.mbtnTaskCopy.Text = "복제";
            this.mbtnTaskCopy.UseSelectable = true;
            this.mbtnTaskCopy.Click += new System.EventHandler(this.mbtnTaskCopy_Click);
            // 
            // mbtnTaskRename
            // 
            this.mbtnTaskRename.Location = new System.Drawing.Point(104, 461);
            this.mbtnTaskRename.Name = "mbtnTaskRename";
            this.mbtnTaskRename.Size = new System.Drawing.Size(75, 23);
            this.mbtnTaskRename.TabIndex = 6;
            this.mbtnTaskRename.Text = "이름 바꾸기";
            this.mbtnTaskRename.UseSelectable = true;
            this.mbtnTaskRename.Click += new System.EventHandler(this.mbtnTaskRename_Click);
            // 
            // mbtnTaskAdd
            // 
            this.mbtnTaskAdd.Location = new System.Drawing.Point(23, 461);
            this.mbtnTaskAdd.Name = "mbtnTaskAdd";
            this.mbtnTaskAdd.Size = new System.Drawing.Size(75, 23);
            this.mbtnTaskAdd.TabIndex = 5;
            this.mbtnTaskAdd.Text = "새 작업";
            this.mbtnTaskAdd.UseSelectable = true;
            this.mbtnTaskAdd.Click += new System.EventHandler(this.mbtnTaskAdd_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(199, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "호스트";
            // 
            // mgrdHost
            // 
            this.mgrdHost.AllowDrop = true;
            this.mgrdHost.AllowUserToResizeRows = false;
            this.mgrdHost.AutoGenerateColumns = false;
            this.mgrdHost.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgrdHost.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgrdHost.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdHost.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgrdHost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgrdHost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.host,
            this.taskIdDataGridViewTextBoxColumn1,
            this.hostDataGridViewTextBoxColumn,
            this.seqDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.paswordDataGridViewTextBoxColumn,
            this.portDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn,
            this.chkDataGridViewTextBoxColumn,
            this.progressDataGridViewTextBoxColumn,
            this.equipNameDataGridViewTextBoxColumn,
            this.outputDataGridViewTextBoxColumn,
            this.onErrorDataGridViewTextBoxColumn,
            this.logTextDataGridViewTextBoxColumn,
            this.logPathDataGridViewTextBoxColumn,
            this.healthCheckDataGridViewTextBoxColumn,
            this.completeDataGridViewTextBoxColumn});
            this.mgrdHost.DataSource = this.hostsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgrdHost.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgrdHost.EnableHeadersVisualStyles = false;
            this.mgrdHost.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgrdHost.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdHost.Location = new System.Drawing.Point(199, 86);
            this.mgrdHost.Name = "mgrdHost";
            this.mgrdHost.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdHost.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgrdHost.RowHeadersVisible = false;
            this.mgrdHost.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgrdHost.RowTemplate.Height = 23;
            this.mgrdHost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgrdHost.Size = new System.Drawing.Size(156, 369);
            this.mgrdHost.TabIndex = 8;
            this.mgrdHost.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.mgrdHost_RowValidating);
            this.mgrdHost.DragDrop += new System.Windows.Forms.DragEventHandler(this.mgrdHost_DragDrop);
            this.mgrdHost.DragEnter += new System.Windows.Forms.DragEventHandler(this.mgrdHost_DragEnter);
            // 
            // host
            // 
            this.host.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.host.DataPropertyName = "host";
            this.host.HeaderText = "호스트";
            this.host.Name = "host";
            this.host.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // taskIdDataGridViewTextBoxColumn1
            // 
            this.taskIdDataGridViewTextBoxColumn1.DataPropertyName = "taskId";
            this.taskIdDataGridViewTextBoxColumn1.HeaderText = "taskId";
            this.taskIdDataGridViewTextBoxColumn1.Name = "taskIdDataGridViewTextBoxColumn1";
            this.taskIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "host";
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            this.hostDataGridViewTextBoxColumn.Visible = false;
            // 
            // seqDataGridViewTextBoxColumn
            // 
            this.seqDataGridViewTextBoxColumn.DataPropertyName = "seq";
            this.seqDataGridViewTextBoxColumn.HeaderText = "seq";
            this.seqDataGridViewTextBoxColumn.Name = "seqDataGridViewTextBoxColumn";
            this.seqDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // paswordDataGridViewTextBoxColumn
            // 
            this.paswordDataGridViewTextBoxColumn.DataPropertyName = "pasword";
            this.paswordDataGridViewTextBoxColumn.HeaderText = "pasword";
            this.paswordDataGridViewTextBoxColumn.Name = "paswordDataGridViewTextBoxColumn";
            this.paswordDataGridViewTextBoxColumn.Visible = false;
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "port";
            this.portDataGridViewTextBoxColumn.HeaderText = "port";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            this.portDataGridViewTextBoxColumn.Visible = false;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "createDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "createDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            this.updateDateDataGridViewTextBoxColumn.DataPropertyName = "updateDate";
            this.updateDateDataGridViewTextBoxColumn.HeaderText = "updateDate";
            this.updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            this.updateDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // chkDataGridViewTextBoxColumn
            // 
            this.chkDataGridViewTextBoxColumn.DataPropertyName = "chk";
            this.chkDataGridViewTextBoxColumn.HeaderText = "chk";
            this.chkDataGridViewTextBoxColumn.Name = "chkDataGridViewTextBoxColumn";
            this.chkDataGridViewTextBoxColumn.Visible = false;
            // 
            // progressDataGridViewTextBoxColumn
            // 
            this.progressDataGridViewTextBoxColumn.DataPropertyName = "progress";
            this.progressDataGridViewTextBoxColumn.HeaderText = "progress";
            this.progressDataGridViewTextBoxColumn.Name = "progressDataGridViewTextBoxColumn";
            this.progressDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipNameDataGridViewTextBoxColumn
            // 
            this.equipNameDataGridViewTextBoxColumn.DataPropertyName = "equipName";
            this.equipNameDataGridViewTextBoxColumn.HeaderText = "equipName";
            this.equipNameDataGridViewTextBoxColumn.Name = "equipNameDataGridViewTextBoxColumn";
            this.equipNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // outputDataGridViewTextBoxColumn
            // 
            this.outputDataGridViewTextBoxColumn.DataPropertyName = "output";
            this.outputDataGridViewTextBoxColumn.HeaderText = "output";
            this.outputDataGridViewTextBoxColumn.Name = "outputDataGridViewTextBoxColumn";
            this.outputDataGridViewTextBoxColumn.Visible = false;
            // 
            // onErrorDataGridViewTextBoxColumn
            // 
            this.onErrorDataGridViewTextBoxColumn.DataPropertyName = "onError";
            this.onErrorDataGridViewTextBoxColumn.HeaderText = "onError";
            this.onErrorDataGridViewTextBoxColumn.Name = "onErrorDataGridViewTextBoxColumn";
            this.onErrorDataGridViewTextBoxColumn.Visible = false;
            // 
            // logTextDataGridViewTextBoxColumn
            // 
            this.logTextDataGridViewTextBoxColumn.DataPropertyName = "logText";
            this.logTextDataGridViewTextBoxColumn.HeaderText = "logText";
            this.logTextDataGridViewTextBoxColumn.Name = "logTextDataGridViewTextBoxColumn";
            this.logTextDataGridViewTextBoxColumn.Visible = false;
            // 
            // logPathDataGridViewTextBoxColumn
            // 
            this.logPathDataGridViewTextBoxColumn.DataPropertyName = "logPath";
            this.logPathDataGridViewTextBoxColumn.HeaderText = "logPath";
            this.logPathDataGridViewTextBoxColumn.Name = "logPathDataGridViewTextBoxColumn";
            this.logPathDataGridViewTextBoxColumn.Visible = false;
            // 
            // healthCheckDataGridViewTextBoxColumn
            // 
            this.healthCheckDataGridViewTextBoxColumn.DataPropertyName = "healthCheck";
            this.healthCheckDataGridViewTextBoxColumn.HeaderText = "healthCheck";
            this.healthCheckDataGridViewTextBoxColumn.Name = "healthCheckDataGridViewTextBoxColumn";
            this.healthCheckDataGridViewTextBoxColumn.Visible = false;
            // 
            // completeDataGridViewTextBoxColumn
            // 
            this.completeDataGridViewTextBoxColumn.DataPropertyName = "complete";
            this.completeDataGridViewTextBoxColumn.HeaderText = "complete";
            this.completeDataGridViewTextBoxColumn.Name = "completeDataGridViewTextBoxColumn";
            this.completeDataGridViewTextBoxColumn.Visible = false;
            // 
            // hostsBindingSource
            // 
            this.hostsBindingSource.DataMember = "FK_task_hosts";
            this.hostsBindingSource.DataSource = this.taskBindingSource;
            this.hostsBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.hostsBindingSource_DataError);
            // 
            // mbtnSave
            // 
            this.mbtnSave.Highlight = true;
            this.mbtnSave.Location = new System.Drawing.Point(788, 490);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 23);
            this.mbtnSave.TabIndex = 10;
            this.mbtnSave.Text = "저장";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // mbtnDelAll
            // 
            this.mbtnDelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mbtnDelAll.Location = new System.Drawing.Point(280, 461);
            this.mbtnDelAll.Name = "mbtnDelAll";
            this.mbtnDelAll.Size = new System.Drawing.Size(75, 23);
            this.mbtnDelAll.TabIndex = 14;
            this.mbtnDelAll.Text = "모두 삭제";
            this.mbtnDelAll.UseSelectable = true;
            this.mbtnDelAll.Click += new System.EventHandler(this.mbtnEelAll_Click);
            // 
            // mbtnHostDelete
            // 
            this.mbtnHostDelete.Location = new System.Drawing.Point(199, 461);
            this.mbtnHostDelete.Name = "mbtnHostDelete";
            this.mbtnHostDelete.Size = new System.Drawing.Size(75, 23);
            this.mbtnHostDelete.TabIndex = 13;
            this.mbtnHostDelete.Text = "삭제";
            this.mbtnHostDelete.UseSelectable = true;
            this.mbtnHostDelete.Click += new System.EventHandler(this.mbtnHostDelete_Click);
            // 
            // mbtnHostExport
            // 
            this.mbtnHostExport.Location = new System.Drawing.Point(280, 490);
            this.mbtnHostExport.Name = "mbtnHostExport";
            this.mbtnHostExport.Size = new System.Drawing.Size(75, 23);
            this.mbtnHostExport.TabIndex = 12;
            this.mbtnHostExport.Text = "내보내기";
            this.mbtnHostExport.UseSelectable = true;
            this.mbtnHostExport.Click += new System.EventHandler(this.mbtnHostExport_Click);
            // 
            // mbtnHostImport
            // 
            this.mbtnHostImport.Location = new System.Drawing.Point(199, 490);
            this.mbtnHostImport.Name = "mbtnHostImport";
            this.mbtnHostImport.Size = new System.Drawing.Size(75, 23);
            this.mbtnHostImport.TabIndex = 11;
            this.mbtnHostImport.Text = "읽어오기";
            this.mbtnHostImport.UseSelectable = true;
            this.mbtnHostImport.Click += new System.EventHandler(this.mbtnHostImport_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(377, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "SSH";
            // 
            // mtxtUserId
            // 
            this.mtxtUserId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "defaultSshId", true));
            this.mtxtUserId.Lines = new string[0];
            this.mtxtUserId.Location = new System.Drawing.Point(498, 86);
            this.mtxtUserId.MaxLength = 32767;
            this.mtxtUserId.Name = "mtxtUserId";
            this.mtxtUserId.PasswordChar = '\0';
            this.mtxtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUserId.SelectedText = "";
            this.mtxtUserId.Size = new System.Drawing.Size(114, 23);
            this.mtxtUserId.TabIndex = 19;
            this.mtxtUserId.UseSelectable = true;
            // 
            // mtxtUserPassword
            // 
            this.mtxtUserPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "defaultSshPassword", true));
            this.mtxtUserPassword.Lines = new string[0];
            this.mtxtUserPassword.Location = new System.Drawing.Point(749, 86);
            this.mtxtUserPassword.MaxLength = 32767;
            this.mtxtUserPassword.Name = "mtxtUserPassword";
            this.mtxtUserPassword.PasswordChar = '●';
            this.mtxtUserPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUserPassword.SelectedText = "";
            this.mtxtUserPassword.Size = new System.Drawing.Size(114, 23);
            this.mtxtUserPassword.TabIndex = 20;
            this.mtxtUserPassword.UseSelectable = true;
            this.mtxtUserPassword.UseSystemPasswordChar = true;
            // 
            // mchkAutoExit
            // 
            this.mchkAutoExit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.taskBindingSource, "autoExitYN", true));
            this.mchkAutoExit.Location = new System.Drawing.Point(749, 115);
            this.mchkAutoExit.Name = "mchkAutoExit";
            this.mchkAutoExit.Size = new System.Drawing.Size(104, 23);
            this.mchkAutoExit.TabIndex = 21;
            this.mchkAutoExit.UseSelectable = true;
            // 
            // mtxtPort
            // 
            this.mtxtPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "defaultSshPort", true));
            this.mtxtPort.Lines = new string[0];
            this.mtxtPort.Location = new System.Drawing.Point(498, 115);
            this.mtxtPort.MaxLength = 32767;
            this.mtxtPort.Name = "mtxtPort";
            this.mtxtPort.PasswordChar = '\0';
            this.mtxtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPort.SelectedText = "";
            this.mtxtPort.Size = new System.Drawing.Size(30, 23);
            this.mtxtPort.TabIndex = 22;
            this.mtxtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtPort.UseSelectable = true;
            // 
            // mtbMaxConnections
            // 
            this.mtbMaxConnections.BackColor = System.Drawing.Color.Transparent;
            this.mtbMaxConnections.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taskBindingSource, "maxConnections", true));
            this.mtbMaxConnections.Location = new System.Drawing.Point(534, 144);
            this.mtbMaxConnections.Maximum = 16;
            this.mtbMaxConnections.Minimum = 1;
            this.mtbMaxConnections.MouseWheelBarPartitions = 15;
            this.mtbMaxConnections.Name = "mtbMaxConnections";
            this.mtbMaxConnections.Size = new System.Drawing.Size(78, 23);
            this.mtbMaxConnections.TabIndex = 23;
            this.mtbMaxConnections.Value = 1;
            this.mtbMaxConnections.ValueChanged += new System.EventHandler(this.mtbMaxConnections_ValueChanged);
            // 
            // mtbTimeOut
            // 
            this.mtbTimeOut.BackColor = System.Drawing.Color.Transparent;
            this.mtbTimeOut.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taskBindingSource, "connectionTimeOut", true));
            this.mtbTimeOut.LargeChange = 1;
            this.mtbTimeOut.Location = new System.Drawing.Point(785, 144);
            this.mtbTimeOut.Maximum = 30;
            this.mtbTimeOut.Minimum = 1;
            this.mtbTimeOut.MouseWheelBarPartitions = 29;
            this.mtbTimeOut.Name = "mtbTimeOut";
            this.mtbTimeOut.Size = new System.Drawing.Size(78, 23);
            this.mtbTimeOut.TabIndex = 24;
            this.mtbTimeOut.Value = 3;
            this.mtbTimeOut.ValueChanged += new System.EventHandler(this.mtbTimeOut_ValueChanged);
            // 
            // mtxtCommand
            // 
            this.mtxtCommand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "commandList", true));
            this.mtxtCommand.Lines = new string[0];
            this.mtxtCommand.Location = new System.Drawing.Point(371, 200);
            this.mtxtCommand.MaxLength = 32767;
            this.mtxtCommand.Multiline = true;
            this.mtxtCommand.Name = "mtxtCommand";
            this.mtxtCommand.PasswordChar = '\0';
            this.mtxtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mtxtCommand.SelectedText = "";
            this.mtxtCommand.Size = new System.Drawing.Size(492, 284);
            this.mtxtCommand.TabIndex = 25;
            this.mtxtCommand.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(371, 86);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(121, 23);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "기본 아이디";
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(622, 86);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 23);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "기본 비밀번호";
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(622, 144);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(121, 23);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "연결 대기시간(초)";
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(371, 144);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(121, 23);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "최대 동시 연결수";
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(622, 115);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(121, 23);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "완료후 연결 끊기";
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(371, 115);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(121, 23);
            this.metroLabel8.TabIndex = 31;
            this.metroLabel8.Text = "기본 포트";
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(371, 174);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(121, 23);
            this.metroLabel9.TabIndex = 32;
            this.metroLabel9.Text = "커맨드 리스트";
            // 
            // mtxtMaxConnections
            // 
            this.mtxtMaxConnections.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "maxConnections", true));
            this.mtxtMaxConnections.Lines = new string[0];
            this.mtxtMaxConnections.Location = new System.Drawing.Point(498, 145);
            this.mtxtMaxConnections.MaxLength = 32767;
            this.mtxtMaxConnections.Name = "mtxtMaxConnections";
            this.mtxtMaxConnections.PasswordChar = '\0';
            this.mtxtMaxConnections.ReadOnly = true;
            this.mtxtMaxConnections.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtMaxConnections.SelectedText = "";
            this.mtxtMaxConnections.Size = new System.Drawing.Size(30, 23);
            this.mtxtMaxConnections.TabIndex = 33;
            this.mtxtMaxConnections.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtMaxConnections.UseSelectable = true;
            // 
            // mtxtTimeOut
            // 
            this.mtxtTimeOut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "connectionTimeOut", true));
            this.mtxtTimeOut.Lines = new string[0];
            this.mtxtTimeOut.Location = new System.Drawing.Point(749, 144);
            this.mtxtTimeOut.MaxLength = 32767;
            this.mtxtTimeOut.Name = "mtxtTimeOut";
            this.mtxtTimeOut.PasswordChar = '\0';
            this.mtxtTimeOut.ReadOnly = true;
            this.mtxtTimeOut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTimeOut.SelectedText = "";
            this.mtxtTimeOut.Size = new System.Drawing.Size(30, 23);
            this.mtxtTimeOut.TabIndex = 34;
            this.mtxtTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtTimeOut.UseSelectable = true;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // hostsTableAdapter
            // 
            this.hostsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hostsTableAdapter = this.hostsTableAdapter;
            this.tableAdapterManager.taskTableAdapter = this.taskTableAdapter;
            this.tableAdapterManager.UpdateOrder = MSSH_WinForm.controls.TaskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "host";
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "호스트";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "taskName";
            this.dataGridViewTextBoxColumn2.HeaderText = "작업명";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "host";
            this.dataGridViewTextBoxColumn3.HeaderText = "호스트";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "taskId";
            this.dataGridViewTextBoxColumn4.HeaderText = "taskId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "host";
            this.dataGridViewTextBoxColumn5.HeaderText = "host";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "seq";
            this.dataGridViewTextBoxColumn6.HeaderText = "seq";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn7.HeaderText = "type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "userId";
            this.dataGridViewTextBoxColumn8.HeaderText = "userId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "pasword";
            this.dataGridViewTextBoxColumn9.HeaderText = "pasword";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "port";
            this.dataGridViewTextBoxColumn10.HeaderText = "port";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "remark";
            this.dataGridViewTextBoxColumn11.HeaderText = "remark";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "createDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "createDate";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "updateDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "updateDate";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "chk";
            this.dataGridViewTextBoxColumn14.HeaderText = "chk";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "progress";
            this.dataGridViewTextBoxColumn15.HeaderText = "progress";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "equipName";
            this.dataGridViewTextBoxColumn16.HeaderText = "equipName";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "output";
            this.dataGridViewTextBoxColumn17.HeaderText = "output";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "onError";
            this.dataGridViewTextBoxColumn18.HeaderText = "onError";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "logText";
            this.dataGridViewTextBoxColumn19.HeaderText = "logText";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "logPath";
            this.dataGridViewTextBoxColumn20.HeaderText = "logPath";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "healthCheck";
            this.dataGridViewTextBoxColumn21.HeaderText = "healthCheck";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "complete";
            this.dataGridViewTextBoxColumn22.HeaderText = "complete";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // MetroTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 536);
            this.Controls.Add(this.mtxtTimeOut);
            this.Controls.Add(this.mtxtMaxConnections);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtxtCommand);
            this.Controls.Add(this.mtbTimeOut);
            this.Controls.Add(this.mtbMaxConnections);
            this.Controls.Add(this.mtxtPort);
            this.Controls.Add(this.mchkAutoExit);
            this.Controls.Add(this.mtxtUserPassword);
            this.Controls.Add(this.mtxtUserId);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mbtnDelAll);
            this.Controls.Add(this.mbtnHostDelete);
            this.Controls.Add(this.mbtnHostExport);
            this.Controls.Add(this.mbtnHostImport);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.mgrdHost);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbtnTaskRename);
            this.Controls.Add(this.mbtnTaskAdd);
            this.Controls.Add(this.mbtnTaskCopy);
            this.Controls.Add(this.mbtnTaskDelete);
            this.Controls.Add(this.mgrdTask);
            this.Controls.Add(this.mlblTaskList);
            this.Controls.Add(this.metroGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetroTaskForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "작업";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MetroTaskForm_FormClosing);
            this.Load += new System.EventHandler(this.MetroTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel mlblTaskList;
        private MetroFramework.Components.MetroStyleManager msmChild;
        private MetroFramework.Controls.MetroGrid mgrdTask;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private TaskDataSetTableAdapters.taskTableAdapter taskTableAdapter;
        private MetroFramework.Controls.MetroButton mbtnTaskCopy;
        private MetroFramework.Controls.MetroButton mbtnTaskDelete;
        private MetroFramework.Controls.MetroButton mbtnTaskRename;
        private MetroFramework.Controls.MetroButton mbtnTaskAdd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid mgrdHost;
        private System.Windows.Forms.BindingSource hostsBindingSource;
        private TaskDataSetTableAdapters.hostsTableAdapter hostsTableAdapter;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroButton mbtnDelAll;
        private MetroFramework.Controls.MetroButton mbtnHostDelete;
        private MetroFramework.Controls.MetroButton mbtnHostExport;
        private MetroFramework.Controls.MetroButton mbtnHostImport;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtUserPassword;
        private MetroFramework.Controls.MetroTextBox mtxtUserId;
        private MetroFramework.Controls.MetroCheckBox mchkAutoExit;
        private MetroFramework.Controls.MetroTextBox mtxtPort;
        private MetroFramework.Controls.MetroTrackBar mtbTimeOut;
        private MetroFramework.Controls.MetroTrackBar mtbMaxConnections;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtxtCommand;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox mtxtMaxConnections;
        private MetroFramework.Controls.MetroTextBox mtxtTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completeDataGridViewTextBoxColumn;
        private TaskDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        public TaskDataSet taskDataSet;
    }
}