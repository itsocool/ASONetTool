using MetroFramework;
using MetroFramework.Forms;
using MSSH_WinForm.controls;
using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MSSH_WinForm
{
    public partial class MainForm : MetroForm
    {
        #region main

        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(MainForm));
        private Dictionary<string, RuleResultVO> ruleMap = new Dictionary<string, RuleResultVO>();
        private string lastResultTextDir = null;

        private int allCount = 0;
        private int passedCount = 0;
        private int failedCount = 0;

        public MainForm()
        {
            try
            {
                logger.Debug("MainForm");
                InitializeComponent();
                DSBinding();
                this.StyleManager = msmMain;
            }
            catch (Exception ex)
            {
                logger.Error("ctor error", ex);
            }
        }

        private void DSBinding()
        {
            hostsTableAdapter.Fill(taskDataSet.hosts);
            taskTableAdapter.Fill(taskDataSet.task);

            mcmbTask.DataSource = taskBindingSource;
            mcmbTask.DisplayMember = "taskName";
            mcmbTask.ValueMember = "taskName";
            checkAllHosts(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string ruleImportDir = Properties.Settings.Default.RULE_IMPORT_DIR;
                string defaultDir = Path.GetDirectoryName(Application.ExecutablePath);
                ruleImportDir = string.IsNullOrWhiteSpace(ruleImportDir) ? defaultDir : ruleImportDir;
                mlblHtmlDir.Text = ruleImportDir;
                Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
                mchkMulti.Text += "(" + Environment.ProcessorCount + " Cores)";
                this.mdtpHtml.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                logger.Error("app main form load error", ex);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (MetroSettingsForm form = new MetroSettingsForm())
            {
                //form.StyleManager = this.StyleManager;
                form.StyleManager.Style = this.StyleManager.Style;
                form.StyleManager.Theme = this.StyleManager.Theme;
                form.StyleManager.Update();
                form.ShowDialog();
            }
        }

        private void btnTaskManage_Click(object sender, EventArgs e)
        {
            try
            {
                MetroTaskForm taskForm = new MetroTaskForm();
                taskForm.StyleManager.Style = this.StyleManager.Style;
                taskForm.StyleManager.Theme = this.StyleManager.Theme;
                taskForm.SelectedTaskName = mcmbTask.SelectedValue.ToString();
                taskForm.ShowDialog();

                if (taskForm.IsChanged)
                {
                    taskDataSet = taskForm.taskDataSet;
                    taskBindingSource.DataSource = taskDataSet;
                    taskBindingSource.ResetBindings(true);
                    hostsBindingSource.ResetBindings(true);
                    mgrdHosts.Refresh();

                    string selctedTaskName = taskForm.SelectedTaskName;
                    string lastTaskName = taskForm.LastTaskName;

                    foreach (DataRowView item in taskBindingSource)
                    {
                        string taskName = (item["taskName"] != null) ? item["taskName"].ToString() : null;
                        if (!string.IsNullOrWhiteSpace(taskName) && lastTaskName == taskName)
                        {
                            mcmbTask.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("open taks form error", ex);
            }
        }

        private void mlnkLight_Click(object sender, EventArgs e)
        {
            msmMain.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void mlnkDark_Click(object sender, EventArgs e)
        {
            msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        #endregion

        #region Rule check

        private void addRule(RuleResultVO vo)
        {

            if (vo != null)
            {
                mgrdHtmlResult.AutoGenerateColumns = false;
                ruleMap = (ruleMap == null) ? new Dictionary<string, RuleResultVO>() : ruleMap;
                ruleMap[vo.FileName] = vo;

                if (vo != null)
                {
                    ruleSetBindingSource.Clear();

                    foreach (var item in ruleMap.Values)
                    {
                        ruleSetBindingSource.Add(item);
                    }

                    ruleSetBindingSource.ResetBindings(false);
                }
            }
        }

        private void delRule(RuleResultVO vo)
        {
            if (vo != null && ruleMap != null && ruleSetBindingSource.Current != null)
            {
                ruleSetBindingSource.RemoveCurrent();
                ruleSetBindingSource.ResetBindings(false);
                ruleMap.Remove(vo.FileName);
            }
        }

        private void btnOpenHtml_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = mdtpHtml.Value;
                RuleResultVO vo = HtmlHelper.OpenHtml(date);
                addRule(vo);
            }
            catch (Exception ex)
            {
                logger.Error("open html error", ex);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                RuleResultVO vo = ruleSetBindingSource.Current as RuleResultVO;
                delRule(vo);
            }
            catch (Exception ex)
            {
                logger.Error("delete html error", ex);
            }
        }

        private void mgrdHtmlResult_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] fileNames = e.Data.GetData(DataFormats.FileDrop, false) as string[];

                    if (fileNames != null && !string.IsNullOrWhiteSpace(fileNames[0]))
                    {
                        string filename = fileNames[0];
                        string ext = Path.GetExtension(filename);
                        if (ext.ToLower() == ".htm" || ext.ToLower() == ".html")
                        {
                            DateTime date = mdtpHtml.Value;
                            RuleResultVO result = HtmlHelper.OpenHtml(date, filename);
                            BindingSource ruleSetBindingSource = new BindingSource();

                            ruleMap[result.FileName] = result;

                            if (result != null)
                            {
                                foreach (var item in ruleMap.Values)
                                {
                                    ruleSetBindingSource.Add(item);
                                }

                                mgrdHtmlResult.AutoGenerateColumns = false;
                                mgrdHtmlResult.DataSource = ruleSetBindingSource;
                                return;
                            }
                        }
                    }

                    MetroMessageBox.Show(this, "한개의 HTML 파일만 가능 합니다.");
                }
            }
            catch (Exception ex)
            {
                logger.Error("open html error", ex);
            }


            //try
            //{
            //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
            //    {
            //        string[] fileNames = e.Data.GetData(DataFormats.FileDrop, false) as string[];

            //        if (fileNames != null && !string.IsNullOrWhiteSpace(fileNames[0]))
            //        {
            //            string filename = fileNames[0];
            //            string ext = Path.GetExtension(filename);
            //            if (ext.ToLower() == ".htm" || ext.ToLower() == ".html")
            //            {
            //                List<RuleVO> rules;
            //                DateTime date = mdtpHtml.Value;
            //                RuleResultVO result = HtmlHelper.OpenHtml(date, filename);
            //                ruleMap[date.ToShortDateString()] = result;
            //                rules = result.Rules;

            //                if (rules != null && rules.Count > 0)
            //                {
            //                    view = new BindingListView<RuleResultVO>(ruleMap.Values.ToList<RuleResultVO>());
            //                    mgrdHtmlResult.AutoGenerateColumns = false;
            //                    mgrdHtmlResult.DataSource = view;
            //                }

            //                return;
            //            }
            //        }

            //        MetroMessageBox.Show("한개의 Excel 파일만 가능 합니다.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    logger.Error( "html drag and drop import error", ex);
            //}
        }

        private void mgrdHtmlResult_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] fileNames = e.Data.GetData(DataFormats.FileDrop, false) as string[];

                    if (fileNames != null && !string.IsNullOrWhiteSpace(fileNames[0]))
                    {
                        string ext = Path.GetExtension(fileNames[0]);
                        if (ext.ToLower() == ".htm" || ext.ToLower() == ".html")
                        {
                            e.Effect = DragDropEffects.All;
                            return;
                        }
                    }
                }

                e.Effect = DragDropEffects.None;
            }
            catch (Exception ex)
            {
                logger.Error("html result drag error", ex);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgrdHtmlResult.Rows != null && mgrdHtmlResult.Rows.Count > 0)
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
                    MetroMessageBox.Show(this, "데이타가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                logger.Error("rule check excel export error", ex);
            }
        }

        private FileStream createExcelReport()
        {
            // 엑셀 열 정보 (1 부터 시작)
            //
            // Hit 0 표 시작 열 : 2
            // Hit 0 표 내용 열 : 5
            // Hit 0 표 합계 열 : 6
            //
            // Expire 표 시작 열 : 9
            // Expire 표 내용 열 : 12
            // Expire 표 합계 열 : 13
            //
            // Any 표 시작 열 : 16
            // Any 표 내용 열 : 19
            // Any 표 합계 열 : 20

            int hit0FirstRowIndex = 1;
            int hit0BodyStartRowIndex = 4;

            int expireFirstRowIndex = 8;
            int expireBodyStartRowIndex = 11;

            int anyFirstRowIndex = 15;
            int anyBodyStartRowIndex = 18;

            //int itemCount = ruleMap.Count;
            int addCount = 0;
            //int idx = 0;

            if (!Directory.Exists("export"))
            {
                System.IO.Directory.CreateDirectory("export");
            }

            string templateFileName = @"Resources\template.xls";
            string exportFileName = @"export\" + DateTime.Now.ToFileTime() + ".xls";
            FileStream templateFs = new FileStream(templateFileName, FileMode.Open, FileAccess.Read);
            FileStream fs = new FileStream(exportFileName, FileMode.Create, FileAccess.ReadWrite);

            // Getting the complete workbook... 
            HSSFWorkbook workbook = new HSSFWorkbook(templateFs, true);
            HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(0);

            sheet.ForceFormulaRecalculation = true;

            templateFs.Close();
            templateFs.Dispose();

            addCount += fillHit0(sheet, hit0FirstRowIndex, hit0BodyStartRowIndex, ruleMap.Values.ToList<RuleResultVO>());

            addCount = addCount - 1;
            expireFirstRowIndex = expireFirstRowIndex + addCount;
            expireBodyStartRowIndex = expireBodyStartRowIndex + addCount;

            addCount += fillExpire(sheet, expireFirstRowIndex, expireBodyStartRowIndex, ruleMap.Values.ToList<RuleResultVO>());

            addCount = addCount - 1;
            anyFirstRowIndex = anyFirstRowIndex + addCount;
            anyBodyStartRowIndex = anyBodyStartRowIndex + addCount;

            addCount += fillAnyRule(sheet, anyFirstRowIndex, anyBodyStartRowIndex, ruleMap.Values.ToList<RuleResultVO>());

            sheet.AutoSizeColumn(1, true);
            workbook.Write(fs);

            return fs;
        }

        private int fillHit0(HSSFSheet sheet, int first, int bodyStart, List<RuleResultVO> list)
        {
            int idx = 0;
            HSSFRow firstRow = (HSSFRow)sheet.GetRow(first);
            HSSFRow bodyStartRow = (HSSFRow)sheet.GetRow(bodyStart);
            HSSFRow row = null;

            foreach (var vo in list)
            {
                if (idx == 0)
                {
                    string dateString = vo.ResultDate.ToString("yyyy년 MM월");
                    firstRow.Cells[1].SetCellValue(dateString);
                    row = bodyStartRow;
                }
                else
                {
                    row = (HSSFRow)bodyStartRow.CopyRowTo(idx + bodyStart);
                }

                row.Cells[0].SetCellValue(vo.FileName);
                row.Cells[1].SetCellValue(vo.OutRuleCount);
                row.Cells[2].SetCellValue(vo.InRuleCount);

                if (vo.OutHit0Count == 0)
                {
                    row.Cells[3].SetCellValue("-");
                }
                else
                {
                    row.Cells[3].SetCellValue(vo.OutHit0Count);
                }

                if (vo.inHit0Count == 0)
                {
                    row.Cells[4].SetCellValue("-");
                }
                else
                {
                    row.Cells[4].SetCellValue(vo.inHit0Count);
                }

                row.Cells[5].SetCellValue("-");
                row.Cells[6].SetCellValue("-");

                idx++;
            }

            HSSFRow lastRow = (HSSFRow)sheet.GetRow(bodyStart + idx);
            lastRow.Cells[1].SetCellFormula("SUM(C" + (bodyStart + 1) + ":C" + (bodyStart + idx) + ")");
            lastRow.Cells[2].SetCellFormula("SUM(D" + (bodyStart + 1) + ":D" + (bodyStart + idx) + ")");
            lastRow.Cells[3].SetCellFormula("SUM(E" + (bodyStart + 1) + ":E" + (bodyStart + idx) + ")");
            lastRow.Cells[4].SetCellFormula("SUM(F" + (bodyStart + 1) + ":F" + (bodyStart + idx) + ")");
            lastRow.Cells[5].SetCellFormula("SUM(G" + (bodyStart + 1) + ":G" + (bodyStart + idx) + ")");
            lastRow.Cells[6].SetCellFormula("SUM(H" + (bodyStart + 1) + ":H" + (bodyStart + idx) + ")");

            return idx;
        }

        private int fillExpire(HSSFSheet sheet, int first, int bodyStart, List<RuleResultVO> list)
        {
            int idx = 0;
            HSSFRow firstRow = (HSSFRow)sheet.GetRow(first);
            HSSFRow bodyStartRow = (HSSFRow)sheet.GetRow(bodyStart);
            HSSFRow row = null;

            foreach (var vo in list)
            {
                if (idx == 0)
                {
                    string dateString = vo.ResultDate.ToString("yyyy년 MM월");
                    firstRow.Cells[1].SetCellValue(dateString);
                    row = bodyStartRow;
                }
                else
                {
                    row = (HSSFRow)bodyStartRow.CopyRowTo(idx + bodyStart);
                }

                row.Cells[0].SetCellValue(vo.FileName);
                row.Cells[1].SetCellValue(vo.OutRuleCount);
                row.Cells[2].SetCellValue(vo.InRuleCount);

                if (vo.OutExpireCount == 0)
                {
                    row.Cells[3].SetCellValue("-");
                }
                else
                {
                    row.Cells[3].SetCellValue(vo.OutExpireCount);
                }

                if (vo.InExpireCount == 0)
                {
                    row.Cells[4].SetCellValue("-");
                }
                else
                {
                    row.Cells[4].SetCellValue(vo.InExpireCount);
                }

                row.Cells[5].SetCellValue("-");
                row.Cells[6].SetCellValue("-");

                idx++;
            }

            HSSFRow lastRow = (HSSFRow)sheet.GetRow(bodyStart + idx);
            lastRow.Cells[1].SetCellFormula("SUM(C" + (bodyStart + 1) + ":C" + (bodyStart + idx) + ")");
            lastRow.Cells[2].SetCellFormula("SUM(D" + (bodyStart + 1) + ":D" + (bodyStart + idx) + ")");
            lastRow.Cells[3].SetCellFormula("SUM(E" + (bodyStart + 1) + ":E" + (bodyStart + idx) + ")");
            lastRow.Cells[4].SetCellFormula("SUM(F" + (bodyStart + 1) + ":F" + (bodyStart + idx) + ")");
            lastRow.Cells[5].SetCellFormula("SUM(G" + (bodyStart + 1) + ":G" + (bodyStart + idx) + ")");
            lastRow.Cells[6].SetCellFormula("SUM(H" + (bodyStart + 1) + ":H" + (bodyStart + idx) + ")");

            return idx;
        }

        private int fillAnyRule(HSSFSheet sheet, int first, int bodyStart, List<RuleResultVO> list)
        {
            int idx = 0;
            HSSFRow firstRow = (HSSFRow)sheet.GetRow(first);
            HSSFRow bodyStartRow = (HSSFRow)sheet.GetRow(bodyStart);
            HSSFRow row = null;

            foreach (var vo in list)
            {
                if (idx == 0)
                {
                    string dateString = vo.ResultDate.ToString("yyyy년 MM월");
                    firstRow.Cells[1].SetCellValue(dateString);
                    row = bodyStartRow;
                }
                else
                {
                    row = (HSSFRow)bodyStartRow.CopyRowTo(idx + bodyStart);
                }

                row.Cells[0].SetCellValue(vo.FileName);
                row.Cells[1].SetCellValue(vo.OutRuleCount);
                row.Cells[2].SetCellValue(vo.InRuleCount);

                if (vo.OutAnySrcRuleCount == 0)
                {
                    row.Cells[3].SetCellValue("-");
                }
                else
                {
                    row.Cells[3].SetCellValue(vo.OutAnySrcRuleCount);
                }

                if (vo.InAnySrcRuleCount == 0)
                {
                    row.Cells[4].SetCellValue("-");
                }
                else
                {
                    row.Cells[4].SetCellValue(vo.InAnySrcRuleCount);
                }

                if (vo.OutAnyDestRuleCount == 0)
                {
                    row.Cells[5].SetCellValue("-");
                }
                else
                {
                    row.Cells[5].SetCellValue(vo.OutAnyDestRuleCount);
                }

                if (vo.InAnyDestRuleCount == 0)
                {
                    row.Cells[6].SetCellValue("-");
                }
                else
                {
                    row.Cells[6].SetCellValue(vo.InAnyDestRuleCount);
                }

                idx++;
            }

            HSSFRow lastRow = (HSSFRow)sheet.GetRow(bodyStart + idx);
            lastRow.Cells[1].SetCellFormula("SUM(C" + (bodyStart + 1) + ":C" + (bodyStart + idx) + ")");
            lastRow.Cells[2].SetCellFormula("SUM(D" + (bodyStart + 1) + ":D" + (bodyStart + idx) + ")");
            lastRow.Cells[3].SetCellFormula("SUM(E" + (bodyStart + 1) + ":E" + (bodyStart + idx) + ")");
            lastRow.Cells[4].SetCellFormula("SUM(F" + (bodyStart + 1) + ":F" + (bodyStart + idx) + ")");
            lastRow.Cells[5].SetCellFormula("SUM(G" + (bodyStart + 1) + ":G" + (bodyStart + idx) + ")");
            lastRow.Cells[6].SetCellFormula("SUM(H" + (bodyStart + 1) + ":H" + (bodyStart + idx) + ")");

            return idx;
        }

        private void btnDupHit0_Click(object sender, EventArgs e)
        {
            if (mgrdHtmlResult.CurrentRow != null)
            {
                RuleResultVO rowView = mgrdHtmlResult.CurrentRow.DataBoundItem as RuleResultVO;
                RuleResultVO voLeft = rowView as RuleResultVO;
                RuleResultVO voRight = HtmlHelper.OpenHtml(DateTime.Now);
                MetroHit0Form form = new MetroHit0Form();
                form.RuleList = getDupRuleList(voLeft.Hit0Rules, voRight.Hit0Rules);
                form.StyleManager = msmMain;
                form.StyleManager.Style = this.StyleManager.Style;
                form.StyleManager.Theme = this.StyleManager.Theme;
                form.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "비교할 원본 파일이 없습니다. Html 파일 결과를 선택해 주세요.");
            }
        }

        private List<RuleVO> getDupRuleList(List<RuleVO> list1, List<RuleVO> list2)
        {

            List<RuleVO> resultList = null;

            if (list1 != null && list1.Count > 0 && list2 != null && list2.Count > 0)
            {
                foreach (var item1 in list1)
                {
                    RuleVO rule = null;

                    foreach (var item2 in list2)
                    {
                        if (item1.Enabled.Equals(item2.Enabled) && item1.InOut.Equals(item2.InOut) && item1.Source.Equals(item2.Source) && item1.Destination.Equals(item2.Destination) && item1.Service.Equals(item2.Service))
                        {
                            rule = item2 as RuleVO;
                            break;
                        }
                    }

                    if (rule != null)
                    {
                        resultList = (resultList == null) ? new List<RuleVO>() : resultList;
                        resultList.Add(rule);
                    }
                }
            }

            return resultList;
        }

        #endregion

        #region Health chek

        private void checkAllHosts(bool value)
        {
            if (taskBindingSource.Current != null && hostsBindingSource.Count > 0)
            {
                foreach (DataRowView row in hostsBindingSource)
                {
                    row["chk"] = value.ToString();
                }
                mgrdHosts.Refresh();
            }
        }

        private void checkAllErrorHosts(bool value)
        {
            if (hostsBindingSource.Count > 0)
            {
                foreach (DataRowView row in hostsBindingSource)
                {
                    bool onError = (row["onError"] != null && row["onError"].ToString() == bool.TrueString) ? true : false;
                    row["chk"] = (onError) ? value.ToString() : (!value).ToString();
                }

                mgrdHosts.Refresh();
            }
        }

        private List<DataRowView> getSelectedHostList(bool init = false)
        {
            List<DataRowView> result = null;

            try
            {
                if (hostsBindingSource.Count > 0)
                {
                    result = new List<DataRowView>();

                    foreach (DataRowView host in hostsBindingSource)
                    {
                        if (host["chk"] != null && host["chk"].ToString() == bool.TrueString)
                        {
                            //if (host == hostsBindingSource.Current)
                            //{
                            //    host.EndEdit();
                            //}

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
            }
            catch (Exception ex)
            {
                logger.Error("체크된 호스트 가져오기 에러", ex);
            }

            return result;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Validate();
            hostsBindingSource.EndEdit();
            mgrdHosts.Refresh();

            logger.Debug("Start GET LOG");
            DataRowView taskRow = taskBindingSource.Current as DataRowView;
            List<DataRowView> hostList = null;
            int threadCount = (mchkMulti.Checked) ? Environment.ProcessorCount : 1;

            hostList = getSelectedHostList(true);

            if (hostList != null && hostList.Count > 0)
            {
                using (MetroProgressForm progressForm = new MetroProgressForm(taskRow, hostList, mgrdHosts, threadCount))
                {
                    progressForm.StyleManager.Theme = msmMain.Theme;
                    progressForm.StyleManager.Style = msmMain.Style;
                    progressForm.ShowDialog();
                    lastResultTextDir = progressForm.mssh.SaveDir;

                    if (!string.IsNullOrWhiteSpace(lastResultTextDir) && Directory.Exists(lastResultTextDir))
                    {
                        mbtnOpenLogDir.Enabled = true;
                    }
                    else
                    {
                        mbtnOpenLogDir.Enabled = false;
                    }
                }
                MetroMessageBox.Show(this, "작업 완료.");
            }
            else
            {
                MetroMessageBox.Show(this, "데이타가 없습니다.");
            }
        }

        private void btnHealthCheck_Click(object sender, EventArgs e)
        {
            List<DataRowView> completeList = new List<DataRowView>();
            List<HealthVO> healthVoList = new List<HealthVO>();
            string fileName = null;
            Util util = new Util();

            completeList = getSelectedHostList();
            healthVoList = util.ParsingHealthChek(completeList);

            if (completeList.Count > 0)
            {
                MetroLoadingForm form = new MetroLoadingForm(hostsBindingSource, healthVoList, mrbtnPDF.Checked);
                form.ShowDialog();
                HCSummaryVO vo = form.SummaryVO;
                fileName = vo.ExportHtmlFileName;

                passedCount = vo.PassedCount;
                failedCount = allCount - vo.PassedCount;

                if (MetroMessageBox.Show(this, "결과 파일을 직접 열겠습니까?", "내보내기", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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
                MetroMessageBox.Show(this, "데이타가 없습니다.");
            }
        }

        private void mbtnReset_Click(object sender, EventArgs e)
        {
            taskDataSet.RejectChanges();
        }

        private void mlnkCheckAll_Click(object sender, EventArgs e)
        {
            checkAllHosts(true);
        }

        private void mlnkUncheckAll_Click(object sender, EventArgs e)
        {
            checkAllHosts(false);
        }

        private void taskBindingSource_PositionChanged(object sender, EventArgs e)
        {
            checkAllHosts(true);
        }

        private void mbtnOpenLogDir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lastResultTextDir))
            {
                Process.Start("explorer.exe", lastResultTextDir);
            }
            else
            {
                MetroMessageBox.Show(this, "폴더 정보가 없습니다.");
            }
        }

        private void mgrdHosts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && hostsBindingSource.Current != null)
                {
                    DataRowView row = hostsBindingSource.Current as DataRowView;
                    if (row["logPath"] != null)
                    {
                        string logPath = row["logPath"].ToString();
                        if (!string.IsNullOrWhiteSpace(logPath) && File.Exists(logPath))
                        {
                            Process.Start("explorer.exe", logPath);
                            return;
                        }
                    }
                }

                MetroMessageBox.Show(this, "파일이 없습니다.");
            }
            catch (Exception ex)
            {
                logger.Error("로그 파일 열기 에러", ex);
            }
        }

        private void SetCountLabel()
        {
            try
            {
                Validate();
                hostsBindingSource.EndEdit();
                mgrdHosts.Refresh();

                int selectCount = 0;

                foreach (DataRowView row in hostsBindingSource)
                {
                    if(row["chk"] != null && row["chk"].ToString() == bool.TrueString)
                    {
                        selectCount++;
                    }
                }

                mlblSelectCount.Text = string.Format("총 {0}개 선택", selectCount);
            }
            catch (Exception ex)
            {
                logger.Error("데이타 카운트 에러", ex);
            }
        }

        private void mgrdHosts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetCountLabel();
        }

        private void mlnkCheckAllError_Click(object sender, EventArgs e)
        {
            checkAllErrorHosts(true);
        }

        private void mlnkUncheckAllError_Click(object sender, EventArgs e)
        {
            checkAllErrorHosts(false);
        }

        private void taskBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            logger.Error("작업 데이타 바인딩 에러", e.Exception);
        }

        private void hostsBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            logger.Error("호스트 데이타 바인딩 에러", e.Exception);
        }

        private void mgrdHosts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            logger.Error("작업 그리드 데이타 에러", e.Exception);
        }

        #endregion

    }
}
