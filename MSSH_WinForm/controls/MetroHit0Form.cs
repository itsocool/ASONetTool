using MetroFramework;
using MetroFramework.Forms;
using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSH_WinForm.controls
{
    public partial class MetroHit0Form : MetroForm
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(MetroHit0Form));
        private List<RuleVO> ruleList = null;

        public MetroHit0Form()
        {
            InitializeComponent();
            this.StyleManager = msmChild;
        }

        public List<RuleVO> RuleList
        {
            get
            {
                return ruleList;
            }

            set
            {
                ruleList = value;

                if (ruleList != null && ruleList.Count > 0)
                {
                    mlblCount.Text = ruleList.Count.ToString();
                    ruleBindingSource = new BindingSource();

                    foreach (var item in ruleList)
                    {
                        ruleBindingSource.Add(item);
                    }
                    mgrdHit0.DataSource = ruleBindingSource;
                }
                else
                {
                    mlblCount.Text = "0";
                }
            }
        }

        private void mbtnExcel_Click(object sender, EventArgs e)
        {
            if (mgrdHit0.RowCount > 0)
            {
                FileStream fs = createExcelReport();
                string fileName = fs.Name;
                fs.Close();
                fs.Dispose();

                if (MetroMessageBox.Show(this, "엑셀 파일을 직접 여시겠습니까?", "선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start(fileName);
                }
                else
                {
                    string argument = @"/select, " + fileName;
                    Process.Start("explorer.exe", argument);
                }
            }
            else
            {
                MetroMessageBox.Show(this,"데이타가 없습니다.");
            }
        }

        private FileStream createExcelReport()
        {

            int first = 3;
            int bodyStart = 4;

            if (!Directory.Exists("export"))
            {
                Directory.CreateDirectory("export");
            }

            String templateFileName = @"Resources\dupHit0.xls";
            String exportFileName = @"export\" + DateTime.Now.ToFileTime() + ".xls";
            FileStream templateFs = new FileStream(templateFileName, FileMode.Open, FileAccess.Read);
            FileStream fs = new FileStream(exportFileName, FileMode.Create, FileAccess.ReadWrite);

            // Getting the complete workbook... 
            HSSFWorkbook workbook = new HSSFWorkbook(templateFs, true);
            HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(0);

            sheet.ForceFormulaRecalculation = true;

            templateFs.Close();
            templateFs.Dispose();

            int idx = 0;
            HSSFRow firstRow = (HSSFRow)sheet.GetRow(first);
            HSSFRow bodyStartRow = (HSSFRow)sheet.GetRow(bodyStart);
            HSSFRow row = null;

            foreach (var item in ruleList)
            {
                row = (idx == 0) ? bodyStartRow : (HSSFRow)bodyStartRow.CopyRowTo(idx + bodyStart);

                row.Cells[0].SetCellValue(item.No);
                row.Cells[1].SetCellValue(item.InOut);
                row.Cells[2].SetCellValue(item.Enabled);
                row.Cells[3].SetCellValue(item.Source);
                row.Cells[4].SetCellValue(item.User);
                row.Cells[5].SetCellValue(item.Destination);
                row.Cells[6].SetCellValue(item.Service);
                row.Cells[7].SetCellValue(item.Action);
                row.Cells[8].SetCellValue(item.Hits);
                row.Cells[9].SetCellValue(item.Logging);
                row.Cells[10].SetCellValue(item.Time);
                row.Cells[11].SetCellValue(item.Description);
                idx++;
            }
            workbook.Write(fs);
            return fs;
        }
    }
}
