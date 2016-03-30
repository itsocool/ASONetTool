using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace MSSH_WinForm.controls
{
    public partial class MetroSettingsForm : MetroForm
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(MetroSettingsForm));
        private FolderBrowserDialog folderDialog;

        public MetroSettingsForm()
        {
            InitializeComponent();
            this.StyleManager = msmChild;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbtnAppDir_Click(object sender, EventArgs e)
        {
            using (folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.APP_DIR = folderDialog.SelectedPath;
                }
            }
        }

        private void mbtnHCReportDir_Click(object sender, EventArgs e)
        {
            using (folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.HC_REPORT_DIR = folderDialog.SelectedPath;
                }
            }
        }

        private void mbtnRuleCheckExcelDir_Click(object sender, EventArgs e)
        {
            using (folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.RULE_CHECK_EXCEL_DIR = folderDialog.SelectedPath;
                }
            }
        }

        private void mbtnTemplateDir_Click(object sender, EventArgs e)
        {
            using (folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.TEMPLATE_DIR = folderDialog.SelectedPath;
                }
            }
        }

        private void mbtnHostImportDir_Click(object sender, EventArgs e)
        {
            using (folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.HOST_IMPORT_DIR = folderDialog.SelectedPath;
                }
            }
        }

        private void mbtnRuleImportDir_Click(object sender, EventArgs e)
        {
            using (folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.RULE_IMPORT_DIR = folderDialog.SelectedPath;
                }
            }
        }
    }
}
