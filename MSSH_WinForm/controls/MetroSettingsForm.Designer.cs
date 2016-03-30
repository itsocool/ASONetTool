namespace MSSH_WinForm.controls
{
    partial class MetroSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroSettingsForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtxtAppDir = new MetroFramework.Controls.MetroTextBox();
            this.mbtnAppDir = new MetroFramework.Controls.MetroButton();
            this.mbtnHCReportDir = new MetroFramework.Controls.MetroButton();
            this.mtxtHCReportDir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mbtnTemplateDir = new MetroFramework.Controls.MetroButton();
            this.mtxtTemplateDir = new MetroFramework.Controls.MetroTextBox();
            this.mlbltmpdir = new MetroFramework.Controls.MetroLabel();
            this.mbtnRuleCheckExcelDir = new MetroFramework.Controls.MetroButton();
            this.mtxtRuleCheckExcelDir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mbtnRuleImportDir = new MetroFramework.Controls.MetroButton();
            this.mtxtRuleImportDir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mbtnHostImportDir = new MetroFramework.Controls.MetroButton();
            this.mtxtHostImportDir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.msmChild = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.msmChild)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(170, 23);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "APP DIR";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxtAppDir
            // 
            this.mtxtAppDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MSSH_WinForm.Properties.Settings.Default, "APP_DIR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mtxtAppDir.Lines = new string[0];
            this.mtxtAppDir.Location = new System.Drawing.Point(199, 95);
            this.mtxtAppDir.MaxLength = 32767;
            this.mtxtAppDir.Name = "mtxtAppDir";
            this.mtxtAppDir.PasswordChar = '\0';
            this.mtxtAppDir.ReadOnly = true;
            this.mtxtAppDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAppDir.SelectedText = "";
            this.mtxtAppDir.Size = new System.Drawing.Size(533, 23);
            this.mtxtAppDir.TabIndex = 15;
            this.mtxtAppDir.Text = global::MSSH_WinForm.Properties.Settings.Default.APP_DIR;
            this.mtxtAppDir.UseSelectable = true;
            // 
            // mbtnAppDir
            // 
            this.mbtnAppDir.Location = new System.Drawing.Point(740, 95);
            this.mbtnAppDir.Name = "mbtnAppDir";
            this.mbtnAppDir.Size = new System.Drawing.Size(23, 23);
            this.mbtnAppDir.TabIndex = 16;
            this.mbtnAppDir.Text = "...";
            this.mbtnAppDir.UseSelectable = true;
            this.mbtnAppDir.Click += new System.EventHandler(this.mbtnAppDir_Click);
            // 
            // mbtnHCReportDir
            // 
            this.mbtnHCReportDir.Location = new System.Drawing.Point(740, 124);
            this.mbtnHCReportDir.Name = "mbtnHCReportDir";
            this.mbtnHCReportDir.Size = new System.Drawing.Size(23, 23);
            this.mbtnHCReportDir.TabIndex = 19;
            this.mbtnHCReportDir.Text = "...";
            this.mbtnHCReportDir.UseSelectable = true;
            this.mbtnHCReportDir.Click += new System.EventHandler(this.mbtnHCReportDir_Click);
            // 
            // mtxtHCReportDir
            // 
            this.mtxtHCReportDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MSSH_WinForm.Properties.Settings.Default, "HC_REPORT_DIR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mtxtHCReportDir.Lines = new string[0];
            this.mtxtHCReportDir.Location = new System.Drawing.Point(199, 124);
            this.mtxtHCReportDir.MaxLength = 32767;
            this.mtxtHCReportDir.Name = "mtxtHCReportDir";
            this.mtxtHCReportDir.PasswordChar = '\0';
            this.mtxtHCReportDir.ReadOnly = true;
            this.mtxtHCReportDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtHCReportDir.SelectedText = "";
            this.mtxtHCReportDir.Size = new System.Drawing.Size(533, 23);
            this.mtxtHCReportDir.TabIndex = 18;
            this.mtxtHCReportDir.Text = global::MSSH_WinForm.Properties.Settings.Default.HC_REPORT_DIR;
            this.mtxtHCReportDir.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(170, 23);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "HC_REPORT_DIR";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mbtnTemplateDir
            // 
            this.mbtnTemplateDir.Location = new System.Drawing.Point(740, 182);
            this.mbtnTemplateDir.Name = "mbtnTemplateDir";
            this.mbtnTemplateDir.Size = new System.Drawing.Size(23, 23);
            this.mbtnTemplateDir.TabIndex = 25;
            this.mbtnTemplateDir.Text = "...";
            this.mbtnTemplateDir.UseSelectable = true;
            this.mbtnTemplateDir.Click += new System.EventHandler(this.mbtnTemplateDir_Click);
            // 
            // mtxtTemplateDir
            // 
            this.mtxtTemplateDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MSSH_WinForm.Properties.Settings.Default, "TEMPLATE_DIR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mtxtTemplateDir.Lines = new string[0];
            this.mtxtTemplateDir.Location = new System.Drawing.Point(199, 182);
            this.mtxtTemplateDir.MaxLength = 32767;
            this.mtxtTemplateDir.Name = "mtxtTemplateDir";
            this.mtxtTemplateDir.PasswordChar = '\0';
            this.mtxtTemplateDir.ReadOnly = true;
            this.mtxtTemplateDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTemplateDir.SelectedText = "";
            this.mtxtTemplateDir.Size = new System.Drawing.Size(533, 23);
            this.mtxtTemplateDir.TabIndex = 24;
            this.mtxtTemplateDir.Text = global::MSSH_WinForm.Properties.Settings.Default.TEMPLATE_DIR;
            this.mtxtTemplateDir.UseSelectable = true;
            // 
            // mlbltmpdir
            // 
            this.mlbltmpdir.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbltmpdir.Location = new System.Drawing.Point(23, 182);
            this.mlbltmpdir.Name = "mlbltmpdir";
            this.mlbltmpdir.Size = new System.Drawing.Size(170, 23);
            this.mlbltmpdir.TabIndex = 23;
            this.mlbltmpdir.Text = "TEMPLATE_DIR";
            this.mlbltmpdir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mbtnRuleCheckExcelDir
            // 
            this.mbtnRuleCheckExcelDir.Location = new System.Drawing.Point(740, 153);
            this.mbtnRuleCheckExcelDir.Name = "mbtnRuleCheckExcelDir";
            this.mbtnRuleCheckExcelDir.Size = new System.Drawing.Size(23, 23);
            this.mbtnRuleCheckExcelDir.TabIndex = 22;
            this.mbtnRuleCheckExcelDir.Text = "...";
            this.mbtnRuleCheckExcelDir.UseSelectable = true;
            this.mbtnRuleCheckExcelDir.Click += new System.EventHandler(this.mbtnRuleCheckExcelDir_Click);
            // 
            // mtxtRuleCheckExcelDir
            // 
            this.mtxtRuleCheckExcelDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MSSH_WinForm.Properties.Settings.Default, "RULE_CHECK_EXCEL_DIR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mtxtRuleCheckExcelDir.Lines = new string[0];
            this.mtxtRuleCheckExcelDir.Location = new System.Drawing.Point(199, 153);
            this.mtxtRuleCheckExcelDir.MaxLength = 32767;
            this.mtxtRuleCheckExcelDir.Name = "mtxtRuleCheckExcelDir";
            this.mtxtRuleCheckExcelDir.PasswordChar = '\0';
            this.mtxtRuleCheckExcelDir.ReadOnly = true;
            this.mtxtRuleCheckExcelDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtRuleCheckExcelDir.SelectedText = "";
            this.mtxtRuleCheckExcelDir.Size = new System.Drawing.Size(533, 23);
            this.mtxtRuleCheckExcelDir.TabIndex = 21;
            this.mtxtRuleCheckExcelDir.Text = global::MSSH_WinForm.Properties.Settings.Default.RULE_CHECK_EXCEL_DIR;
            this.mtxtRuleCheckExcelDir.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(23, 153);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(170, 23);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "RULE_CHECK_EXCEL_DIR";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mbtnRuleImportDir
            // 
            this.mbtnRuleImportDir.Location = new System.Drawing.Point(740, 240);
            this.mbtnRuleImportDir.Name = "mbtnRuleImportDir";
            this.mbtnRuleImportDir.Size = new System.Drawing.Size(23, 23);
            this.mbtnRuleImportDir.TabIndex = 31;
            this.mbtnRuleImportDir.Text = "...";
            this.mbtnRuleImportDir.UseSelectable = true;
            this.mbtnRuleImportDir.Click += new System.EventHandler(this.mbtnRuleImportDir_Click);
            // 
            // mtxtRuleImportDir
            // 
            this.mtxtRuleImportDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MSSH_WinForm.Properties.Settings.Default, "RULE_IMPORT_DIR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mtxtRuleImportDir.Lines = new string[0];
            this.mtxtRuleImportDir.Location = new System.Drawing.Point(199, 240);
            this.mtxtRuleImportDir.MaxLength = 32767;
            this.mtxtRuleImportDir.Name = "mtxtRuleImportDir";
            this.mtxtRuleImportDir.PasswordChar = '\0';
            this.mtxtRuleImportDir.ReadOnly = true;
            this.mtxtRuleImportDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtRuleImportDir.SelectedText = "";
            this.mtxtRuleImportDir.Size = new System.Drawing.Size(533, 23);
            this.mtxtRuleImportDir.TabIndex = 30;
            this.mtxtRuleImportDir.Text = global::MSSH_WinForm.Properties.Settings.Default.RULE_IMPORT_DIR;
            this.mtxtRuleImportDir.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(23, 240);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(170, 23);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "RULE_IMPORT_DIR";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mbtnHostImportDir
            // 
            this.mbtnHostImportDir.Location = new System.Drawing.Point(740, 211);
            this.mbtnHostImportDir.Name = "mbtnHostImportDir";
            this.mbtnHostImportDir.Size = new System.Drawing.Size(23, 23);
            this.mbtnHostImportDir.TabIndex = 28;
            this.mbtnHostImportDir.Text = "...";
            this.mbtnHostImportDir.UseSelectable = true;
            this.mbtnHostImportDir.Click += new System.EventHandler(this.mbtnHostImportDir_Click);
            // 
            // mtxtHostImportDir
            // 
            this.mtxtHostImportDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MSSH_WinForm.Properties.Settings.Default, "HOST_IMPORT_DIR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mtxtHostImportDir.Lines = new string[0];
            this.mtxtHostImportDir.Location = new System.Drawing.Point(199, 211);
            this.mtxtHostImportDir.MaxLength = 32767;
            this.mtxtHostImportDir.Name = "mtxtHostImportDir";
            this.mtxtHostImportDir.PasswordChar = '\0';
            this.mtxtHostImportDir.ReadOnly = true;
            this.mtxtHostImportDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtHostImportDir.SelectedText = "";
            this.mtxtHostImportDir.Size = new System.Drawing.Size(533, 23);
            this.mtxtHostImportDir.TabIndex = 27;
            this.mtxtHostImportDir.Text = global::MSSH_WinForm.Properties.Settings.Default.HOST_IMPORT_DIR;
            this.mtxtHostImportDir.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(23, 211);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(170, 23);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "HOST_IMPORT_DIR";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // msmChild
            // 
            this.msmChild.Owner = this;
            // 
            // MetroSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 286);
            this.Controls.Add(this.mbtnRuleImportDir);
            this.Controls.Add(this.mtxtRuleImportDir);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mbtnHostImportDir);
            this.Controls.Add(this.mtxtHostImportDir);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mbtnTemplateDir);
            this.Controls.Add(this.mtxtTemplateDir);
            this.Controls.Add(this.mlbltmpdir);
            this.Controls.Add(this.mbtnRuleCheckExcelDir);
            this.Controls.Add(this.mtxtRuleCheckExcelDir);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mbtnHCReportDir);
            this.Controls.Add(this.mtxtHCReportDir);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mbtnAppDir);
            this.Controls.Add(this.mtxtAppDir);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetroSettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "환경설정";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.msmChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtxtAppDir;
        private MetroFramework.Controls.MetroButton mbtnAppDir;
        private MetroFramework.Controls.MetroButton mbtnHCReportDir;
        private MetroFramework.Controls.MetroTextBox mtxtHCReportDir;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mbtnTemplateDir;
        private MetroFramework.Controls.MetroTextBox mtxtTemplateDir;
        private MetroFramework.Controls.MetroLabel mlbltmpdir;
        private MetroFramework.Controls.MetroButton mbtnRuleCheckExcelDir;
        private MetroFramework.Controls.MetroTextBox mtxtRuleCheckExcelDir;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton mbtnRuleImportDir;
        private MetroFramework.Controls.MetroTextBox mtxtRuleImportDir;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton mbtnHostImportDir;
        private MetroFramework.Controls.MetroTextBox mtxtHostImportDir;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Components.MetroStyleManager msmChild;
    }
}