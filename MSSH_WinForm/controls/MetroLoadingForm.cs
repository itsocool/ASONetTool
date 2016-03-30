using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSH_WinForm.controls
{
    public partial class MetroLoadingForm : MetroForm
    {
        private BindingSource hostsBindingSource = null;
        public HCSummaryVO SummaryVO { get; private set; } = null;
        public string FileName { get; private set; } = null;
        private List<HealthVO> healthVoList = null;
        public bool exportPDF = true;

        public MetroLoadingForm(BindingSource source, List<HealthVO> VoList, bool exportPDF)
        {
            InitializeComponent();
            hostsBindingSource = source;
            healthVoList = VoList;
            this.exportPDF = exportPDF;
        }

        private void MetroLoadingForm_Load(object sender, EventArgs e)
        {
            Util util = new Util();

            if (healthVoList.Count > 0)
            {
                SummaryVO = util.makeHtml(healthVoList);

                foreach (var item in healthVoList)
                {
                    if (item == null || string.IsNullOrWhiteSpace(item.HostName))
                    {
                        continue;
                    }

                    foreach (DataRowView row in hostsBindingSource)
                    {
                        if (row["equipName"].ToString() != null && item.HostName == row["equipName"].ToString())
                        {
                            row["healthCheck"] = item.OverAll;
                            break;
                        }
                    }
                }

                FileName = SummaryVO.ExportHtmlFileName;

                if (exportPDF)
                {
                    FileName = Path.Combine(Path.GetDirectoryName(SummaryVO.ExportHtmlFileName), Path.GetFileNameWithoutExtension(SummaryVO.ExportHtmlFileName) + ".pdf");
                    HtmlHelper.Html2Pdf(SummaryVO.ExportHtmlFileName, FileName);
                    SummaryVO.ExportHtmlFileName = FileName;
                }
            }

            Close();
        }

        private List<DataRowView> getSelectedHostList(bool init = false)
        {
            List<DataRowView> result = null;

            if (hostsBindingSource.Count > 0)
            {
                Validate();
                hostsBindingSource.EndEdit();
                result = new List<DataRowView>();

                foreach (DataRowView host in hostsBindingSource)
                {
                    if (host["chk"] != null && host["chk"].ToString() == bool.TrueString)
                    {
                        if (init)
                        {
                            host["progress"] = null;
                            host["onError"] = null;
                            host["output"] = null;
                            host["logText"] = null;
                            host["equipName"] = null;
                            host["logPath"] = null;
                            host["complete"] = null;
                        }
                        result.Add(host);
                    }
                }
            }

            return result;
        }
    }
}
