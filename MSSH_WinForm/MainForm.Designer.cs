namespace MSSH_WinForm
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mlnkSettings = new MetroFramework.Controls.MetroLink();
            this.mlnkTaskManage = new MetroFramework.Controls.MetroLink();
            this.hostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskDataSet = new MSSH_WinForm.controls.TaskDataSet();
            this.mlnkLight = new MetroFramework.Controls.MetroLink();
            this.mlnkDark = new MetroFramework.Controls.MetroLink();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.taskTableAdapter = new MSSH_WinForm.controls.TaskDataSetTableAdapters.taskTableAdapter();
            this.hostsTableAdapter = new MSSH_WinForm.controls.TaskDataSetTableAdapters.hostsTableAdapter();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.mlblSelectCount = new MetroFramework.Controls.MetroLabel();
            this.mlnkUncheckAllError = new MetroFramework.Controls.MetroLink();
            this.mlnkCheckAllError = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mrbtnHTML = new MetroFramework.Controls.MetroRadioButton();
            this.mrbtnPDF = new MetroFramework.Controls.MetroRadioButton();
            this.mbtnOpenLogDir = new MetroFramework.Controls.MetroButton();
            this.mlnkUncheckAll = new MetroFramework.Controls.MetroLink();
            this.mlnkCheckAll = new MetroFramework.Controls.MetroLink();
            this.mgrdHosts = new MetroFramework.Controls.MetroGrid();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onError = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.complete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.healthCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTextDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logPathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrtbHealthResult = new MetroFramework.Drawing.Html.HtmlLabel();
            this.mchkMulti = new MetroFramework.Controls.MetroCheckBox();
            this.mbtnReset = new MetroFramework.Controls.MetroButton();
            this.mbtnHealthCheck = new MetroFramework.Controls.MetroButton();
            this.mcmbTask = new MetroFramework.Controls.MetroComboBox();
            this.mbtnStart = new MetroFramework.Controls.MetroButton();
            this.mlblTaskSelect = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.mgrdHtmlResult = new MetroFramework.Controls.MetroGrid();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InRuleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inHit0Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InExpireCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InAnySrcRuleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InAnyDestRuleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutRuleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutHit0Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutExpireCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutAnySrcRuleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutAnyDestRuleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Report = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ruleSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mlblHtmlDir = new MetroFramework.Controls.MetroLabel();
            this.mlnkHtmlDir = new MetroFramework.Controls.MetroLink();
            this.mbtnDel = new MetroFramework.Controls.MetroButton();
            this.mbtnDupHit0 = new MetroFramework.Controls.MetroButton();
            this.mbtnRuleReport = new MetroFramework.Controls.MetroButton();
            this.mdtpHtml = new MetroFramework.Controls.MetroDateTime();
            this.mbtnHtml = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onErrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdHosts)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdHtmlResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleSetBindingSource)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlnkSettings
            // 
            this.mlnkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlnkSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkSettings.BackgroundImage")));
            this.mlnkSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mlnkSettings.Location = new System.Drawing.Point(1042, 8);
            this.mlnkSettings.Name = "mlnkSettings";
            this.mlnkSettings.Size = new System.Drawing.Size(46, 16);
            this.mlnkSettings.TabIndex = 6;
            this.mlnkSettings.Text = "설정";
            this.mlnkSettings.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mlnkSettings.UseSelectable = true;
            this.mlnkSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // mlnkTaskManage
            // 
            this.mlnkTaskManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlnkTaskManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkTaskManage.BackgroundImage")));
            this.mlnkTaskManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mlnkTaskManage.Location = new System.Drawing.Point(957, 8);
            this.mlnkTaskManage.Name = "mlnkTaskManage";
            this.mlnkTaskManage.Size = new System.Drawing.Size(78, 16);
            this.mlnkTaskManage.TabIndex = 7;
            this.mlnkTaskManage.Text = "작업 관리";
            this.mlnkTaskManage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mlnkTaskManage.UseSelectable = true;
            this.mlnkTaskManage.Click += new System.EventHandler(this.btnTaskManage_Click);
            // 
            // hostsBindingSource
            // 
            this.hostsBindingSource.DataMember = "FK_task_hosts";
            this.hostsBindingSource.DataSource = this.taskBindingSource;
            this.hostsBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.hostsBindingSource_DataError);
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "task";
            this.taskBindingSource.DataSource = this.taskDataSet;
            this.taskBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.taskBindingSource_DataError);
            this.taskBindingSource.PositionChanged += new System.EventHandler(this.taskBindingSource_PositionChanged);
            // 
            // taskDataSet
            // 
            this.taskDataSet.DataSetName = "TaskDataSet";
            this.taskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mlnkLight
            // 
            this.mlnkLight.Location = new System.Drawing.Point(411, 5);
            this.mlnkLight.Name = "mlnkLight";
            this.mlnkLight.Size = new System.Drawing.Size(41, 23);
            this.mlnkLight.TabIndex = 9;
            this.mlnkLight.Text = "Light";
            this.mlnkLight.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mlnkLight.UseSelectable = true;
            this.mlnkLight.Click += new System.EventHandler(this.mlnkLight_Click);
            // 
            // mlnkDark
            // 
            this.mlnkDark.Location = new System.Drawing.Point(453, 5);
            this.mlnkDark.Name = "mlnkDark";
            this.mlnkDark.Size = new System.Drawing.Size(41, 23);
            this.mlnkDark.TabIndex = 10;
            this.mlnkDark.Text = "Dark";
            this.mlnkDark.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlnkDark.UseSelectable = true;
            this.mlnkDark.Click += new System.EventHandler(this.mlnkDark_Click);
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // hostsTableAdapter
            // 
            this.hostsTableAdapter.ClearBeforeFill = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.mlblSelectCount);
            this.metroTabPage2.Controls.Add(this.mlnkUncheckAllError);
            this.metroTabPage2.Controls.Add(this.mlnkCheckAllError);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.mrbtnHTML);
            this.metroTabPage2.Controls.Add(this.mrbtnPDF);
            this.metroTabPage2.Controls.Add(this.mbtnOpenLogDir);
            this.metroTabPage2.Controls.Add(this.mlnkUncheckAll);
            this.metroTabPage2.Controls.Add(this.mlnkCheckAll);
            this.metroTabPage2.Controls.Add(this.mgrdHosts);
            this.metroTabPage2.Controls.Add(this.mrtbHealthResult);
            this.metroTabPage2.Controls.Add(this.mchkMulti);
            this.metroTabPage2.Controls.Add(this.mbtnReset);
            this.metroTabPage2.Controls.Add(this.mbtnHealthCheck);
            this.metroTabPage2.Controls.Add(this.mcmbTask);
            this.metroTabPage2.Controls.Add(this.mbtnStart);
            this.metroTabPage2.Controls.Add(this.mlblTaskSelect);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1138, 558);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Health Check";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // mlblSelectCount
            // 
            this.mlblSelectCount.Location = new System.Drawing.Point(592, 45);
            this.mlblSelectCount.Name = "mlblSelectCount";
            this.mlblSelectCount.Size = new System.Drawing.Size(136, 23);
            this.mlblSelectCount.TabIndex = 59;
            this.mlblSelectCount.Text = "총 0개 선택";
            this.mlblSelectCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlnkUncheckAllError
            // 
            this.mlnkUncheckAllError.Location = new System.Drawing.Point(253, 45);
            this.mlnkUncheckAllError.Name = "mlnkUncheckAllError";
            this.mlnkUncheckAllError.Size = new System.Drawing.Size(100, 23);
            this.mlnkUncheckAllError.TabIndex = 58;
            this.mlnkUncheckAllError.Text = "에러 제외 선택";
            this.mlnkUncheckAllError.UseSelectable = true;
            this.mlnkUncheckAllError.Click += new System.EventHandler(this.mlnkUncheckAllError_Click);
            // 
            // mlnkCheckAllError
            // 
            this.mlnkCheckAllError.Location = new System.Drawing.Point(169, 45);
            this.mlnkCheckAllError.Name = "mlnkCheckAllError";
            this.mlnkCheckAllError.Size = new System.Drawing.Size(78, 23);
            this.mlnkCheckAllError.TabIndex = 57;
            this.mlnkCheckAllError.Text = "에러만 선택";
            this.mlnkCheckAllError.UseSelectable = true;
            this.mlnkCheckAllError.Click += new System.EventHandler(this.mlnkCheckAllError_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(496, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "내보내기 형식";
            // 
            // mrbtnHTML
            // 
            this.mrbtnHTML.AutoSize = true;
            this.mrbtnHTML.Location = new System.Drawing.Point(649, 16);
            this.mrbtnHTML.Name = "mrbtnHTML";
            this.mrbtnHTML.Size = new System.Drawing.Size(56, 15);
            this.mrbtnHTML.TabIndex = 55;
            this.mrbtnHTML.Text = "HTML";
            this.mrbtnHTML.UseSelectable = true;
            // 
            // mrbtnPDF
            // 
            this.mrbtnPDF.AutoSize = true;
            this.mrbtnPDF.Checked = true;
            this.mrbtnPDF.Location = new System.Drawing.Point(599, 16);
            this.mrbtnPDF.Name = "mrbtnPDF";
            this.mrbtnPDF.Size = new System.Drawing.Size(44, 15);
            this.mrbtnPDF.TabIndex = 54;
            this.mrbtnPDF.TabStop = true;
            this.mrbtnPDF.Text = "PDF";
            this.mrbtnPDF.UseSelectable = true;
            // 
            // mbtnOpenLogDir
            // 
            this.mbtnOpenLogDir.Location = new System.Drawing.Point(1021, 12);
            this.mbtnOpenLogDir.Name = "mbtnOpenLogDir";
            this.mbtnOpenLogDir.Size = new System.Drawing.Size(114, 23);
            this.mbtnOpenLogDir.TabIndex = 53;
            this.mbtnOpenLogDir.Text = "로그 폴더 열기";
            this.mbtnOpenLogDir.UseSelectable = true;
            this.mbtnOpenLogDir.Click += new System.EventHandler(this.mbtnOpenLogDir_Click);
            // 
            // mlnkUncheckAll
            // 
            this.mlnkUncheckAll.Location = new System.Drawing.Point(88, 45);
            this.mlnkUncheckAll.Name = "mlnkUncheckAll";
            this.mlnkUncheckAll.Size = new System.Drawing.Size(75, 23);
            this.mlnkUncheckAll.TabIndex = 52;
            this.mlnkUncheckAll.Text = "모두 해제";
            this.mlnkUncheckAll.UseSelectable = true;
            this.mlnkUncheckAll.Click += new System.EventHandler(this.mlnkUncheckAll_Click);
            // 
            // mlnkCheckAll
            // 
            this.mlnkCheckAll.Location = new System.Drawing.Point(7, 45);
            this.mlnkCheckAll.Name = "mlnkCheckAll";
            this.mlnkCheckAll.Size = new System.Drawing.Size(75, 23);
            this.mlnkCheckAll.TabIndex = 51;
            this.mlnkCheckAll.Text = "모두 선택";
            this.mlnkCheckAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlnkCheckAll.UseSelectable = true;
            this.mlnkCheckAll.Click += new System.EventHandler(this.mlnkCheckAll_Click);
            // 
            // mgrdHosts
            // 
            this.mgrdHosts.AllowUserToAddRows = false;
            this.mgrdHosts.AllowUserToDeleteRows = false;
            this.mgrdHosts.AllowUserToResizeRows = false;
            this.mgrdHosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mgrdHosts.AutoGenerateColumns = false;
            this.mgrdHosts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdHosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgrdHosts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgrdHosts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdHosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.mgrdHosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgrdHosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.host,
            this.progress,
            this.equipName,
            this.onError,
            this.complete,
            this.healthCheck,
            this.output,
            this.logTextDataGridViewTextBoxColumn1,
            this.logPathDataGridViewTextBoxColumn1});
            this.mgrdHosts.DataSource = this.hostsBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgrdHosts.DefaultCellStyle = dataGridViewCellStyle6;
            this.mgrdHosts.EnableHeadersVisualStyles = false;
            this.mgrdHosts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgrdHosts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdHosts.Location = new System.Drawing.Point(0, 74);
            this.mgrdHosts.Name = "mgrdHosts";
            this.mgrdHosts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdHosts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgrdHosts.RowHeadersVisible = false;
            this.mgrdHosts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgrdHosts.RowTemplate.Height = 23;
            this.mgrdHosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgrdHosts.Size = new System.Drawing.Size(728, 470);
            this.mgrdHosts.TabIndex = 50;
            this.mgrdHosts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrdHosts_CellContentDoubleClick);
            this.mgrdHosts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.mgrdHosts_DataBindingComplete);
            this.mgrdHosts.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.mgrdHosts_DataError);
            // 
            // chk
            // 
            this.chk.DataPropertyName = "chk";
            this.chk.FalseValue = "False";
            this.chk.FillWeight = 40F;
            this.chk.HeaderText = " ";
            this.chk.Name = "chk";
            this.chk.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk.TrueValue = "True";
            this.chk.Width = 40;
            // 
            // host
            // 
            this.host.DataPropertyName = "host";
            this.host.HeaderText = "호스트";
            this.host.Name = "host";
            this.host.ReadOnly = true;
            this.host.ToolTipText = "더블클릭시 로그 파일열기";
            // 
            // progress
            // 
            this.progress.DataPropertyName = "progress";
            this.progress.FillWeight = 80F;
            this.progress.HeaderText = "진행";
            this.progress.Name = "progress";
            this.progress.ReadOnly = true;
            this.progress.Width = 80;
            // 
            // equipName
            // 
            this.equipName.DataPropertyName = "equipName";
            this.equipName.FillWeight = 130F;
            this.equipName.HeaderText = "장비명";
            this.equipName.Name = "equipName";
            this.equipName.ReadOnly = true;
            this.equipName.ToolTipText = "더블클릭시 로그 파일열기";
            this.equipName.Width = 130;
            // 
            // onError
            // 
            this.onError.DataPropertyName = "onError";
            this.onError.FillWeight = 40F;
            this.onError.HeaderText = "에러";
            this.onError.Name = "onError";
            this.onError.ReadOnly = true;
            this.onError.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.onError.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.onError.Width = 40;
            // 
            // complete
            // 
            this.complete.DataPropertyName = "complete";
            this.complete.HeaderText = "완료";
            this.complete.Name = "complete";
            this.complete.ReadOnly = true;
            this.complete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.complete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.complete.Width = 40;
            // 
            // healthCheck
            // 
            this.healthCheck.DataPropertyName = "healthCheck";
            this.healthCheck.FillWeight = 50F;
            this.healthCheck.HeaderText = "HC Passed";
            this.healthCheck.Name = "healthCheck";
            this.healthCheck.ReadOnly = true;
            this.healthCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.healthCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.healthCheck.Width = 50;
            // 
            // output
            // 
            this.output.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.output.DataPropertyName = "output";
            this.output.FillWeight = 200F;
            this.output.HeaderText = "Output";
            this.output.Name = "output";
            this.output.ReadOnly = true;
            // 
            // logTextDataGridViewTextBoxColumn1
            // 
            this.logTextDataGridViewTextBoxColumn1.DataPropertyName = "logText";
            this.logTextDataGridViewTextBoxColumn1.HeaderText = "로그 내용";
            this.logTextDataGridViewTextBoxColumn1.Name = "logTextDataGridViewTextBoxColumn1";
            this.logTextDataGridViewTextBoxColumn1.Visible = false;
            // 
            // logPathDataGridViewTextBoxColumn1
            // 
            this.logPathDataGridViewTextBoxColumn1.DataPropertyName = "logPath";
            this.logPathDataGridViewTextBoxColumn1.HeaderText = "로그 파일";
            this.logPathDataGridViewTextBoxColumn1.Name = "logPathDataGridViewTextBoxColumn1";
            this.logPathDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logPathDataGridViewTextBoxColumn1.Visible = false;
            this.logPathDataGridViewTextBoxColumn1.Width = 40;
            // 
            // mrtbHealthResult
            // 
            this.mrtbHealthResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mrtbHealthResult.AutoScroll = true;
            this.mrtbHealthResult.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.mrtbHealthResult.AutoSize = false;
            this.mrtbHealthResult.BackColor = System.Drawing.SystemColors.Window;
            this.mrtbHealthResult.Location = new System.Drawing.Point(737, 74);
            this.mrtbHealthResult.Name = "mrtbHealthResult";
            this.mrtbHealthResult.Size = new System.Drawing.Size(398, 470);
            this.mrtbHealthResult.TabIndex = 49;
            // 
            // mchkMulti
            // 
            this.mchkMulti.AutoSize = true;
            this.mchkMulti.Checked = true;
            this.mchkMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchkMulti.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mchkMulti.Location = new System.Drawing.Point(711, 14);
            this.mchkMulti.Name = "mchkMulti";
            this.mchkMulti.Size = new System.Drawing.Size(85, 19);
            this.mchkMulti.TabIndex = 48;
            this.mchkMulti.Text = "다중 실행";
            this.mchkMulti.UseSelectable = true;
            // 
            // mbtnReset
            // 
            this.mbtnReset.Location = new System.Drawing.Point(415, 12);
            this.mbtnReset.Name = "mbtnReset";
            this.mbtnReset.Size = new System.Drawing.Size(75, 23);
            this.mbtnReset.TabIndex = 46;
            this.mbtnReset.Text = "초기화";
            this.mbtnReset.UseSelectable = true;
            this.mbtnReset.Click += new System.EventHandler(this.mbtnReset_Click);
            // 
            // mbtnHealthCheck
            // 
            this.mbtnHealthCheck.Location = new System.Drawing.Point(334, 12);
            this.mbtnHealthCheck.Name = "mbtnHealthCheck";
            this.mbtnHealthCheck.Size = new System.Drawing.Size(75, 23);
            this.mbtnHealthCheck.TabIndex = 45;
            this.mbtnHealthCheck.Text = "헬스체크";
            this.mbtnHealthCheck.UseSelectable = true;
            this.mbtnHealthCheck.Click += new System.EventHandler(this.btnHealthCheck_Click);
            // 
            // mcmbTask
            // 
            this.mcmbTask.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mcmbTask.FormattingEnabled = true;
            this.mcmbTask.ItemHeight = 19;
            this.mcmbTask.Location = new System.Drawing.Point(79, 11);
            this.mcmbTask.Name = "mcmbTask";
            this.mcmbTask.Size = new System.Drawing.Size(168, 25);
            this.mcmbTask.TabIndex = 44;
            this.mcmbTask.UseSelectable = true;
            // 
            // mbtnStart
            // 
            this.mbtnStart.Highlight = true;
            this.mbtnStart.Location = new System.Drawing.Point(253, 12);
            this.mbtnStart.Name = "mbtnStart";
            this.mbtnStart.Size = new System.Drawing.Size(75, 23);
            this.mbtnStart.TabIndex = 43;
            this.mbtnStart.Text = "시작";
            this.mbtnStart.UseSelectable = true;
            this.mbtnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // mlblTaskSelect
            // 
            this.mlblTaskSelect.AutoSize = true;
            this.mlblTaskSelect.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblTaskSelect.Location = new System.Drawing.Point(3, 14);
            this.mlblTaskSelect.Name = "mlblTaskSelect";
            this.mlblTaskSelect.Size = new System.Drawing.Size(65, 19);
            this.mlblTaskSelect.TabIndex = 42;
            this.mlblTaskSelect.Text = "작업선택";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1130, 2);
            this.label2.TabIndex = 34;
            this.label2.Text = "label2";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.mgrdHtmlResult);
            this.metroTabPage1.Controls.Add(this.mlblHtmlDir);
            this.metroTabPage1.Controls.Add(this.mlnkHtmlDir);
            this.metroTabPage1.Controls.Add(this.mbtnDel);
            this.metroTabPage1.Controls.Add(this.mbtnDupHit0);
            this.metroTabPage1.Controls.Add(this.mbtnRuleReport);
            this.metroTabPage1.Controls.Add(this.mdtpHtml);
            this.metroTabPage1.Controls.Add(this.mbtnHtml);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1138, 558);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Rule Check";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // mgrdHtmlResult
            // 
            this.mgrdHtmlResult.AllowDrop = true;
            this.mgrdHtmlResult.AllowUserToAddRows = false;
            this.mgrdHtmlResult.AllowUserToResizeRows = false;
            this.mgrdHtmlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgrdHtmlResult.AutoGenerateColumns = false;
            this.mgrdHtmlResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdHtmlResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgrdHtmlResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgrdHtmlResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdHtmlResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgrdHtmlResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgrdHtmlResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.ResultDate,
            this.InRuleCount,
            this.inHit0Count,
            this.InExpireCount,
            this.InAnySrcRuleCount,
            this.InAnyDestRuleCount,
            this.OutRuleCount,
            this.OutHit0Count,
            this.OutExpireCount,
            this.OutAnySrcRuleCount,
            this.OutAnyDestRuleCount,
            this.Report});
            this.mgrdHtmlResult.DataSource = this.ruleSetBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgrdHtmlResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.mgrdHtmlResult.EnableHeadersVisualStyles = false;
            this.mgrdHtmlResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgrdHtmlResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdHtmlResult.Location = new System.Drawing.Point(3, 43);
            this.mgrdHtmlResult.Name = "mgrdHtmlResult";
            this.mgrdHtmlResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdHtmlResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgrdHtmlResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgrdHtmlResult.RowTemplate.Height = 23;
            this.mgrdHtmlResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgrdHtmlResult.Size = new System.Drawing.Size(1132, 520);
            this.mgrdHtmlResult.TabIndex = 56;
            this.mgrdHtmlResult.DragDrop += new System.Windows.Forms.DragEventHandler(this.mgrdHtmlResult_DragDrop);
            this.mgrdHtmlResult.DragEnter += new System.Windows.Forms.DragEventHandler(this.mgrdHtmlResult_DragEnter);
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "파일명";
            this.FileName.Name = "FileName";
            // 
            // ResultDate
            // 
            this.ResultDate.DataPropertyName = "ResultDate";
            dataGridViewCellStyle2.Format = "yyyy-MM";
            dataGridViewCellStyle2.NullValue = null;
            this.ResultDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ResultDate.HeaderText = "날짜";
            this.ResultDate.Name = "ResultDate";
            this.ResultDate.Width = 60;
            // 
            // InRuleCount
            // 
            this.InRuleCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.InRuleCount.DataPropertyName = "InRuleCount";
            this.InRuleCount.HeaderText = "IN Total";
            this.InRuleCount.Name = "InRuleCount";
            this.InRuleCount.Width = 64;
            // 
            // inHit0Count
            // 
            this.inHit0Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.inHit0Count.DataPropertyName = "inHit0Count";
            this.inHit0Count.HeaderText = "IN Hit 0";
            this.inHit0Count.Name = "inHit0Count";
            this.inHit0Count.Width = 58;
            // 
            // InExpireCount
            // 
            this.InExpireCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.InExpireCount.DataPropertyName = "InExpireCount";
            this.InExpireCount.HeaderText = "IN Expire";
            this.InExpireCount.Name = "InExpireCount";
            this.InExpireCount.Width = 69;
            // 
            // InAnySrcRuleCount
            // 
            this.InAnySrcRuleCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.InAnySrcRuleCount.DataPropertyName = "InAnySrcRuleCount";
            this.InAnySrcRuleCount.HeaderText = "IN SRC Any";
            this.InAnySrcRuleCount.Name = "InAnySrcRuleCount";
            this.InAnySrcRuleCount.Width = 79;
            // 
            // InAnyDestRuleCount
            // 
            this.InAnyDestRuleCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.InAnyDestRuleCount.DataPropertyName = "InAnyDestRuleCount";
            this.InAnyDestRuleCount.HeaderText = "IN DEST Any";
            this.InAnyDestRuleCount.Name = "InAnyDestRuleCount";
            this.InAnyDestRuleCount.Width = 84;
            // 
            // OutRuleCount
            // 
            this.OutRuleCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OutRuleCount.DataPropertyName = "OutRuleCount";
            this.OutRuleCount.HeaderText = "OUT Total";
            this.OutRuleCount.Name = "OutRuleCount";
            this.OutRuleCount.Width = 74;
            // 
            // OutHit0Count
            // 
            this.OutHit0Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OutHit0Count.DataPropertyName = "OutHit0Count";
            this.OutHit0Count.HeaderText = "OUT Hit 0";
            this.OutHit0Count.Name = "OutHit0Count";
            this.OutHit0Count.Width = 67;
            // 
            // OutExpireCount
            // 
            this.OutExpireCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OutExpireCount.DataPropertyName = "OutExpireCount";
            this.OutExpireCount.HeaderText = "OUT Expire";
            this.OutExpireCount.Name = "OutExpireCount";
            this.OutExpireCount.Width = 79;
            // 
            // OutAnySrcRuleCount
            // 
            this.OutAnySrcRuleCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OutAnySrcRuleCount.DataPropertyName = "OutAnySrcRuleCount";
            this.OutAnySrcRuleCount.HeaderText = "OUT SRc Any";
            this.OutAnySrcRuleCount.Name = "OutAnySrcRuleCount";
            this.OutAnySrcRuleCount.Width = 70;
            // 
            // OutAnyDestRuleCount
            // 
            this.OutAnyDestRuleCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OutAnyDestRuleCount.DataPropertyName = "OutAnyDestRuleCount";
            this.OutAnyDestRuleCount.HeaderText = "OUT DEST Any";
            this.OutAnyDestRuleCount.Name = "OutAnyDestRuleCount";
            this.OutAnyDestRuleCount.Width = 94;
            // 
            // Report
            // 
            this.Report.HeaderText = "엑셀로 내보내기";
            this.Report.Name = "Report";
            this.Report.Text = "Export";
            this.Report.UseColumnTextForButtonValue = true;
            this.Report.Visible = false;
            // 
            // ruleSetBindingSource
            // 
            this.ruleSetBindingSource.DataSource = typeof(MSSH_WinForm.controls.RuleResultVO);
            // 
            // mlblHtmlDir
            // 
            this.mlblHtmlDir.AutoSize = true;
            this.mlblHtmlDir.Location = new System.Drawing.Point(489, 14);
            this.mlblHtmlDir.MinimumSize = new System.Drawing.Size(60, 19);
            this.mlblHtmlDir.Name = "mlblHtmlDir";
            this.mlblHtmlDir.Size = new System.Drawing.Size(12, 19);
            this.mlblHtmlDir.TabIndex = 55;
            this.mlblHtmlDir.Text = ".";
            // 
            // mlnkHtmlDir
            // 
            this.mlnkHtmlDir.Location = new System.Drawing.Point(422, 12);
            this.mlnkHtmlDir.Name = "mlnkHtmlDir";
            this.mlnkHtmlDir.Size = new System.Drawing.Size(60, 23);
            this.mlnkHtmlDir.TabIndex = 54;
            this.mlnkHtmlDir.Text = "HTML Dir";
            this.mlnkHtmlDir.UseSelectable = true;
            // 
            // mbtnDel
            // 
            this.mbtnDel.Location = new System.Drawing.Point(84, 12);
            this.mbtnDel.Name = "mbtnDel";
            this.mbtnDel.Size = new System.Drawing.Size(75, 23);
            this.mbtnDel.TabIndex = 53;
            this.mbtnDel.Text = "삭제";
            this.mbtnDel.UseSelectable = true;
            this.mbtnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // mbtnDupHit0
            // 
            this.mbtnDupHit0.Location = new System.Drawing.Point(324, 12);
            this.mbtnDupHit0.Name = "mbtnDupHit0";
            this.mbtnDupHit0.Size = new System.Drawing.Size(75, 23);
            this.mbtnDupHit0.TabIndex = 52;
            this.mbtnDupHit0.Text = "HIT0 비교";
            this.mbtnDupHit0.UseSelectable = true;
            this.mbtnDupHit0.Click += new System.EventHandler(this.btnDupHit0_Click);
            // 
            // mbtnRuleReport
            // 
            this.mbtnRuleReport.Highlight = true;
            this.mbtnRuleReport.Location = new System.Drawing.Point(243, 12);
            this.mbtnRuleReport.Name = "mbtnRuleReport";
            this.mbtnRuleReport.Size = new System.Drawing.Size(75, 23);
            this.mbtnRuleReport.TabIndex = 51;
            this.mbtnRuleReport.Text = "Report";
            this.mbtnRuleReport.UseSelectable = true;
            this.mbtnRuleReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // mdtpHtml
            // 
            this.mdtpHtml.CustomFormat = "yyyy-MM";
            this.mdtpHtml.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.mdtpHtml.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mdtpHtml.Location = new System.Drawing.Point(165, 11);
            this.mdtpHtml.MinimumSize = new System.Drawing.Size(4, 25);
            this.mdtpHtml.Name = "mdtpHtml";
            this.mdtpHtml.Size = new System.Drawing.Size(72, 25);
            this.mdtpHtml.TabIndex = 50;
            // 
            // mbtnHtml
            // 
            this.mbtnHtml.Location = new System.Drawing.Point(3, 12);
            this.mbtnHtml.Name = "mbtnHtml";
            this.mbtnHtml.Size = new System.Drawing.Size(75, 23);
            this.mbtnHtml.TabIndex = 49;
            this.mbtnHtml.Text = "Html 추가";
            this.mbtnHtml.UseSelectable = true;
            this.mbtnHtml.Click += new System.EventHandler(this.btnOpenHtml_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1146, 606);
            this.metroTabControl1.TabIndex = 8;
            this.metroTabControl1.UseSelectable = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "엑셀로 내보내기";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Export";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "chk";
            this.dataGridViewCheckBoxColumn1.FalseValue = "False";
            this.dataGridViewCheckBoxColumn1.FillWeight = 40F;
            this.dataGridViewCheckBoxColumn1.HeaderText = " ";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "True";
            this.dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn1.HeaderText = "파일명";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "더블클릭시 로그 파일열기";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ResultDate";
            dataGridViewCellStyle8.Format = "yyyy-MM";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.FillWeight = 80F;
            this.dataGridViewTextBoxColumn2.HeaderText = "날짜";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "InRuleCount";
            this.dataGridViewTextBoxColumn3.FillWeight = 130F;
            this.dataGridViewTextBoxColumn3.HeaderText = "IN Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.ToolTipText = "더블클릭시 로그 파일열기";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "onError";
            this.dataGridViewCheckBoxColumn2.FillWeight = 40F;
            this.dataGridViewCheckBoxColumn2.HeaderText = "에러";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.Width = 40;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "complete";
            this.dataGridViewCheckBoxColumn3.HeaderText = "완료";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn3.Width = 40;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "healthCheck";
            this.dataGridViewCheckBoxColumn4.FillWeight = 50F;
            this.dataGridViewCheckBoxColumn4.HeaderText = "HC Passed";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "inHit0Count";
            this.dataGridViewTextBoxColumn4.FillWeight = 200F;
            this.dataGridViewTextBoxColumn4.HeaderText = "IN Hit 0";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "InExpireCount";
            this.dataGridViewTextBoxColumn5.HeaderText = "IN Expire";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "InAnySrcRuleCount";
            this.dataGridViewTextBoxColumn6.HeaderText = "IN SRC Any";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "InAnyDestRuleCount";
            this.dataGridViewTextBoxColumn7.HeaderText = "IN DEST Any";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OutRuleCount";
            this.dataGridViewTextBoxColumn8.HeaderText = "OUT Total";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OutHit0Count";
            this.dataGridViewTextBoxColumn9.HeaderText = "OUT Hit 0";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OutExpireCount";
            this.dataGridViewTextBoxColumn10.HeaderText = "OUT Expire";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OutAnySrcRuleCount";
            this.dataGridViewTextBoxColumn11.HeaderText = "OUT SRc Any";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OutAnyDestRuleCount";
            this.dataGridViewTextBoxColumn12.HeaderText = "OUT DEST Any";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "host";
            this.dataGridViewTextBoxColumn13.HeaderText = "호스트";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.ToolTipText = "더블클릭시 로그 파일열기";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "progress";
            this.dataGridViewTextBoxColumn14.FillWeight = 80F;
            this.dataGridViewTextBoxColumn14.HeaderText = "진행";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "equipName";
            this.dataGridViewTextBoxColumn15.FillWeight = 130F;
            this.dataGridViewTextBoxColumn15.HeaderText = "장비명";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.ToolTipText = "더블클릭시 로그 파일열기";
            this.dataGridViewTextBoxColumn15.Width = 130;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "output";
            this.dataGridViewTextBoxColumn16.FillWeight = 200F;
            this.dataGridViewTextBoxColumn16.HeaderText = "Output";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "logText";
            this.dataGridViewTextBoxColumn17.HeaderText = "logText";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "logPath";
            this.dataGridViewTextBoxColumn18.HeaderText = "logPath";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn18.Visible = false;
            this.dataGridViewTextBoxColumn18.Width = 40;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "logPath";
            this.dataGridViewImageColumn1.HeaderText = "로그 파일";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.DataPropertyName = "logPath";
            this.dataGridViewLinkColumn1.HeaderText = "로그 파일";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn1.Text = "....";
            this.dataGridViewLinkColumn1.Width = 40;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.DataPropertyName = "logPath";
            this.dataGridViewButtonColumn2.HeaderText = "로그 파일";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn2.Text = "...";
            this.dataGridViewButtonColumn2.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "host";
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            // 
            // seqDataGridViewTextBoxColumn
            // 
            this.seqDataGridViewTextBoxColumn.DataPropertyName = "seq";
            this.seqDataGridViewTextBoxColumn.HeaderText = "seq";
            this.seqDataGridViewTextBoxColumn.Name = "seqDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // paswordDataGridViewTextBoxColumn
            // 
            this.paswordDataGridViewTextBoxColumn.DataPropertyName = "pasword";
            this.paswordDataGridViewTextBoxColumn.HeaderText = "pasword";
            this.paswordDataGridViewTextBoxColumn.Name = "paswordDataGridViewTextBoxColumn";
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "port";
            this.portDataGridViewTextBoxColumn.HeaderText = "port";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            // 
            // chkDataGridViewTextBoxColumn
            // 
            this.chkDataGridViewTextBoxColumn.DataPropertyName = "chk";
            this.chkDataGridViewTextBoxColumn.HeaderText = "chk";
            this.chkDataGridViewTextBoxColumn.Name = "chkDataGridViewTextBoxColumn";
            // 
            // progressDataGridViewTextBoxColumn
            // 
            this.progressDataGridViewTextBoxColumn.DataPropertyName = "progress";
            this.progressDataGridViewTextBoxColumn.HeaderText = "progress";
            this.progressDataGridViewTextBoxColumn.Name = "progressDataGridViewTextBoxColumn";
            // 
            // equipNameDataGridViewTextBoxColumn
            // 
            this.equipNameDataGridViewTextBoxColumn.DataPropertyName = "equipName";
            this.equipNameDataGridViewTextBoxColumn.HeaderText = "equipName";
            this.equipNameDataGridViewTextBoxColumn.Name = "equipNameDataGridViewTextBoxColumn";
            // 
            // outputDataGridViewTextBoxColumn
            // 
            this.outputDataGridViewTextBoxColumn.DataPropertyName = "output";
            this.outputDataGridViewTextBoxColumn.HeaderText = "output";
            this.outputDataGridViewTextBoxColumn.Name = "outputDataGridViewTextBoxColumn";
            // 
            // onErrorDataGridViewTextBoxColumn
            // 
            this.onErrorDataGridViewTextBoxColumn.DataPropertyName = "onError";
            this.onErrorDataGridViewTextBoxColumn.HeaderText = "onError";
            this.onErrorDataGridViewTextBoxColumn.Name = "onErrorDataGridViewTextBoxColumn";
            // 
            // logTextDataGridViewTextBoxColumn
            // 
            this.logTextDataGridViewTextBoxColumn.DataPropertyName = "logText";
            this.logTextDataGridViewTextBoxColumn.HeaderText = "logText";
            this.logTextDataGridViewTextBoxColumn.Name = "logTextDataGridViewTextBoxColumn";
            // 
            // logPathDataGridViewTextBoxColumn
            // 
            this.logPathDataGridViewTextBoxColumn.DataPropertyName = "logPath";
            this.logPathDataGridViewTextBoxColumn.HeaderText = "logPath";
            this.logPathDataGridViewTextBoxColumn.Name = "logPathDataGridViewTextBoxColumn";
            // 
            // healthCheckDataGridViewTextBoxColumn
            // 
            this.healthCheckDataGridViewTextBoxColumn.DataPropertyName = "healthCheck";
            this.healthCheckDataGridViewTextBoxColumn.HeaderText = "healthCheck";
            this.healthCheckDataGridViewTextBoxColumn.Name = "healthCheckDataGridViewTextBoxColumn";
            // 
            // completeDataGridViewTextBoxColumn
            // 
            this.completeDataGridViewTextBoxColumn.DataPropertyName = "complete";
            this.completeDataGridViewTextBoxColumn.HeaderText = "complete";
            this.completeDataGridViewTextBoxColumn.Name = "completeDataGridViewTextBoxColumn";
            // 
            // taskIdDataGridViewTextBoxColumn1
            // 
            this.taskIdDataGridViewTextBoxColumn1.DataPropertyName = "taskId";
            this.taskIdDataGridViewTextBoxColumn1.HeaderText = "taskId";
            this.taskIdDataGridViewTextBoxColumn1.Name = "taskIdDataGridViewTextBoxColumn1";
            // 
            // remarkDataGridViewTextBoxColumn1
            // 
            this.remarkDataGridViewTextBoxColumn1.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn1.HeaderText = "remark";
            this.remarkDataGridViewTextBoxColumn1.Name = "remarkDataGridViewTextBoxColumn1";
            // 
            // createDateDataGridViewTextBoxColumn1
            // 
            this.createDateDataGridViewTextBoxColumn1.DataPropertyName = "createDate";
            this.createDateDataGridViewTextBoxColumn1.HeaderText = "createDate";
            this.createDateDataGridViewTextBoxColumn1.Name = "createDateDataGridViewTextBoxColumn1";
            // 
            // updateDateDataGridViewTextBoxColumn1
            // 
            this.updateDateDataGridViewTextBoxColumn1.DataPropertyName = "updateDate";
            this.updateDateDataGridViewTextBoxColumn1.HeaderText = "updateDate";
            this.updateDateDataGridViewTextBoxColumn1.Name = "updateDateDataGridViewTextBoxColumn1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(1186, 686);
            this.Controls.Add(this.mlnkTaskManage);
            this.Controls.Add(this.mlnkSettings);
            this.Controls.Add(this.mlnkDark);
            this.Controls.Add(this.mlnkLight);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "MSSH Tool(WinForm) ver ";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdHosts)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdHtmlResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleSetBindingSource)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink mlnkSettings;
        private MetroFramework.Controls.MetroLink mlnkTaskManage;
        private MetroFramework.Controls.MetroLink mlnkLight;
        private MetroFramework.Controls.MetroLink mlnkDark;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private controls.TaskDataSetTableAdapters.taskTableAdapter taskTableAdapter;
        private System.Windows.Forms.BindingSource hostsBindingSource;
        private controls.TaskDataSetTableAdapters.hostsTableAdapter hostsTableAdapter;
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
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource ruleSetBindingSource;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroGrid mgrdHtmlResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InRuleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn inHit0Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn InExpireCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InAnySrcRuleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InAnyDestRuleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutRuleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutHit0Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutExpireCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutAnySrcRuleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutAnyDestRuleCount;
        private System.Windows.Forms.DataGridViewButtonColumn Report;
        private MetroFramework.Controls.MetroLabel mlblHtmlDir;
        private MetroFramework.Controls.MetroLink mlnkHtmlDir;
        private MetroFramework.Controls.MetroButton mbtnDel;
        private MetroFramework.Controls.MetroButton mbtnDupHit0;
        private MetroFramework.Controls.MetroButton mbtnRuleReport;
        private MetroFramework.Controls.MetroDateTime mdtpHtml;
        private MetroFramework.Controls.MetroButton mbtnHtml;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel mlblSelectCount;
        private MetroFramework.Controls.MetroLink mlnkUncheckAllError;
        private MetroFramework.Controls.MetroLink mlnkCheckAllError;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton mrbtnHTML;
        private MetroFramework.Controls.MetroRadioButton mrbtnPDF;
        private MetroFramework.Controls.MetroButton mbtnOpenLogDir;
        private MetroFramework.Controls.MetroLink mlnkUncheckAll;
        private MetroFramework.Controls.MetroLink mlnkCheckAll;
        private MetroFramework.Controls.MetroGrid mgrdHosts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onError;
        private System.Windows.Forms.DataGridViewCheckBoxColumn complete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn healthCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn output;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTextDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn logPathDataGridViewTextBoxColumn1;
        private MetroFramework.Drawing.Html.HtmlLabel mrtbHealthResult;
        private MetroFramework.Controls.MetroCheckBox mchkMulti;
        private MetroFramework.Controls.MetroButton mbtnReset;
        private MetroFramework.Controls.MetroButton mbtnHealthCheck;
        private MetroFramework.Controls.MetroComboBox mcmbTask;
        private MetroFramework.Controls.MetroButton mbtnStart;
        private MetroFramework.Controls.MetroLabel mlblTaskSelect;
        private System.Windows.Forms.Label label2;
        private controls.TaskDataSet taskDataSet;
    }
}

