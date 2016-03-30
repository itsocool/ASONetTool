using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MSSH_WinForm.controls
{
    class ExcelHelper
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(ExcelHelper));

        static public DataSet importExcel(string path)
        {
            DataSet ds = null;

            if(File.Exists(path))
            {
                try
                {
                    IWorkbook wb;
                    ISheet sheet;
                    string ext = Path.GetExtension(path);
                    ds = new DataSet();

                    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        if (ext.ToLower() == ".xls")
                        {
                            wb = new HSSFWorkbook(fs);
                        }
                        else
                        {
                            wb = new XSSFWorkbook(fs);
                        }
                    }

                    sheet = wb.GetSheetAt(0);
                    DataTable dt = new DataTable(sheet.SheetName);
                    IRow firstRow = sheet.GetRow(sheet.FirstRowNum);
                    int idx = 1;

                    for (int col = firstRow.FirstCellNum; col < firstRow.LastCellNum; col++)
                    {
                        ICell cell = firstRow.GetCell(col);
                        Type t = typeof(string);

                        if (cell != null)
                        {
                            CellType cellType = cell.CellType;

                            if (cellType == CellType.Numeric)
                            {
                                t = typeof(double);
                            }

                            DataColumn dc = new DataColumn("col" + idx.ToString(), t);
                            dt.Columns.Add(dc);
                            idx++;
                        }
                    }

                    for (int row = sheet.FirstRowNum; row <= sheet.LastRowNum; row++)
                    {
                        DataRow dr = dt.NewRow();
                        IRow excelRow = sheet.GetRow(row);

                        if (excelRow != null) //null is when the row only contains empty cells 
                        {
                            for (int i = excelRow.FirstCellNum; i < excelRow.LastCellNum; i++)
                            {
                                ICell cell = null;

                                if (dt.Columns[i].DataType == typeof(double))
                                {
                                    cell = excelRow.GetCell(i);
                                    dr[i] = cell.NumericCellValue;
                                }
                                else
                                {
                                    cell = excelRow.GetCell(i);
                                    dr[i] = cell.StringCellValue;
                                }
                            }
                        }

                        dt.Rows.Add(dr);
                    }

                    ds.Tables.Add(dt);
                }
                catch (Exception ex)
                {
                    logger.Error( "excel import error", ex);
                    throw;
                }

            }

            return ds;
        }

        static public IWorkbook exportExcel(DataGridView dgv, string path)
        {
            IWorkbook wb = null; ;
            ISheet sheet;
            try
            {

                if (dgv != null && dgv.RowCount > 0)
                {
                    DataGridViewRow firstRow = dgv.Rows[0];
                    wb = new HSSFWorkbook();
                    sheet = wb.CreateSheet("HostList");
                    sheet.SetColumnWidth(0, 20 * 256);//Host

                    for (int j = 0; j <= dgv.RowCount; j++)
                    {
                        DataGridViewRow row = dgv.Rows[j];
                        
                        if(row != null && row.Cells.Count > 0)
                        {
                            DataGridViewCell cell = row.Cells["host"];
                            
                            if(cell != null && cell.Value != null)
                            {
                                IRow excelRow = sheet.CreateRow(j);
                                excelRow.CreateCell(0).SetCellValue(cell.Value.ToString());
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                logger.Error( "Excel export exception", ex);
            }
            return wb;
        }

        //static private int fillHit0(HSSFSheet sheet, int first, int bodyStart, IList<RuleResultVO> list)
        //{
        //    int idx = 0;
        //    HSSFRow firstRow = (HSSFRow)sheet.GetRow(first);
        //    HSSFRow bodyStartRow = (HSSFRow)sheet.GetRow(bodyStart);
        //    HSSFRow row = null;

        //    foreach (var vo in list)
        //    {
        //        if (idx == 0)
        //        {
        //            string dateString = vo.ResultDate.ToString("yyyy년 MM월");
        //            firstRow.Cells[1].SetCellValue(dateString);
        //            row = bodyStartRow;
        //        }
        //        else
        //        {
        //            row = (HSSFRow)bodyStartRow.CopyRowTo(idx + bodyStart);
        //        }

        //        row.Cells[0].SetCellValue(vo.FileName);
        //        row.Cells[1].SetCellValue(vo.OutRuleCount);
        //        row.Cells[2].SetCellValue(vo.InRuleCount);

        //        if (vo.OutHit0Count == 0)
        //        {
        //            row.Cells[3].SetCellValue("-");
        //        }
        //        else
        //        {
        //            row.Cells[3].SetCellValue(vo.OutHit0Count);
        //        }

        //        if (vo.inHit0Count == 0)
        //        {
        //            row.Cells[4].SetCellValue("-");
        //        }
        //        else
        //        {
        //            row.Cells[4].SetCellValue(vo.inHit0Count);
        //        }

        //        row.Cells[5].SetCellValue("-");
        //        row.Cells[6].SetCellValue("-");

        //        idx++;
        //    }

        //    HSSFRow lastRow = (HSSFRow)sheet.GetRow(bodyStart + idx);
        //    lastRow.Cells[1].SetCellFormula("SUM(C" + (bodyStart + 1) + ":C" + (bodyStart + idx) + ")");
        //    lastRow.Cells[2].SetCellFormula("SUM(D" + (bodyStart + 1) + ":D" + (bodyStart + idx) + ")");
        //    lastRow.Cells[3].SetCellFormula("SUM(E" + (bodyStart + 1) + ":E" + (bodyStart + idx) + ")");
        //    lastRow.Cells[4].SetCellFormula("SUM(F" + (bodyStart + 1) + ":F" + (bodyStart + idx) + ")");
        //    lastRow.Cells[5].SetCellFormula("SUM(G" + (bodyStart + 1) + ":G" + (bodyStart + idx) + ")");
        //    lastRow.Cells[6].SetCellFormula("SUM(H" + (bodyStart + 1) + ":H" + (bodyStart + idx) + ")");

        //    return idx;
        //}

        //static private int fillExpire(HSSFSheet sheet, int first, int bodyStart, IList<RuleResultVO> list)
        //{
        //    int idx = 0;
        //    HSSFRow firstRow = (HSSFRow)sheet.GetRow(first);
        //    HSSFRow bodyStartRow = (HSSFRow)sheet.GetRow(bodyStart);
        //    HSSFRow row = null;

        //    foreach (var vo in list)
        //    {
        //        if (idx == 0)
        //        {
        //            string dateString = vo.ResultDate.ToString("yyyy년 MM월");
        //            firstRow.Cells[1].SetCellValue(dateString);
        //            row = bodyStartRow;
        //        }
        //        else
        //        {
        //            row = (HSSFRow)bodyStartRow.CopyRowTo(idx + bodyStart);
        //        }

        //        row.Cells[0].SetCellValue(vo.FileName);
        //        row.Cells[1].SetCellValue(vo.OutRuleCount);
        //        row.Cells[2].SetCellValue(vo.InRuleCount);

        //        if (vo.OutExpireCount == 0)
        //        {
        //            row.Cells[3].SetCellValue("-");
        //        }
        //        else
        //        {
        //            row.Cells[3].SetCellValue(vo.OutExpireCount);
        //        }

        //        if (vo.InExpireCount == 0)
        //        {
        //            row.Cells[4].SetCellValue("-");
        //        }
        //        else
        //        {
        //            row.Cells[4].SetCellValue(vo.InExpireCount);
        //        }

        //        row.Cells[5].SetCellValue("-");
        //        row.Cells[6].SetCellValue("-");

        //        idx++;
        //    }

        //    HSSFRow lastRow = (HSSFRow)sheet.GetRow(bodyStart + idx);
        //    lastRow.Cells[1].SetCellFormula("SUM(C" + (bodyStart + 1) + ":C" + (bodyStart + idx) + ")");
        //    lastRow.Cells[2].SetCellFormula("SUM(D" + (bodyStart + 1) + ":D" + (bodyStart + idx) + ")");
        //    lastRow.Cells[3].SetCellFormula("SUM(E" + (bodyStart + 1) + ":E" + (bodyStart + idx) + ")");
        //    lastRow.Cells[4].SetCellFormula("SUM(F" + (bodyStart + 1) + ":F" + (bodyStart + idx) + ")");
        //    lastRow.Cells[5].SetCellFormula("SUM(G" + (bodyStart + 1) + ":G" + (bodyStart + idx) + ")");
        //    lastRow.Cells[6].SetCellFormula("SUM(H" + (bodyStart + 1) + ":H" + (bodyStart + idx) + ")");

        //    return idx;
        //}

        //static private int fillAnyRule(HSSFSheet sheet, int first, int bodyStart, IList<RuleResultVO> list)
        //{
        //    int idx = 0;
        //    HSSFRow firstRow = (HSSFRow)sheet.GetRow(first);
        //    HSSFRow bodyStartRow = (HSSFRow)sheet.GetRow(bodyStart);
        //    HSSFRow row = null;

        //    foreach (var vo in list)
        //    {
        //        if (idx == 0)
        //        {
        //            string dateString = vo.ResultDate.ToString("yyyy년 MM월");
        //            firstRow.Cells[1].SetCellValue(dateString);
        //            row = bodyStartRow;
        //        }
        //        else
        //        {
        //            row = (HSSFRow)bodyStartRow.CopyRowTo(idx + bodyStart);
        //        }

        //        row.Cells[0].SetCellValue(vo.FileName);
        //        row.Cells[1].SetCellValue(vo.OutRuleCount);
        //        row.Cells[2].SetCellValue(vo.InRuleCount);

        //        if (vo.OutAnySrcRuleCount == 0)
        //        {
        //            row.Cells[3].SetCellValue("-");
        //        }
        //        else
        //        {
        //            row.Cells[3].SetCellValue(vo.OutAnySrcRuleCount);
        //        }

        //        if (vo.InAnySrcRuleCount == 0)
        //        {
        //            row.Cells[4].SetCellValue("-");
        //        }
        //        else
        //        {
        //            row.Cells[4].SetCellValue(vo.InAnySrcRuleCount);
        //        }

        //        if (vo.OutAnyDestRuleCount == 0)
        //        {
        //            row.Cells[5].SetCellValue("-");
        //        }
        //        else
        //        {
        //            row.Cells[5].SetCellValue(vo.OutAnyDestRuleCount);
        //        }

        //        if (vo.InAnyDestRuleCount == 0)
        //        {
        //            row.Cells[6].SetCellValue("-");
        //        }
        //        else
        //        {
        //            row.Cells[6].SetCellValue(vo.InAnyDestRuleCount);
        //        }

        //        idx++;
        //    }

        //    HSSFRow lastRow = (HSSFRow)sheet.GetRow(bodyStart + idx);
        //    lastRow.Cells[1].SetCellFormula("SUM(C" + (bodyStart + 1) + ":C" + (bodyStart + idx) + ")");
        //    lastRow.Cells[2].SetCellFormula("SUM(D" + (bodyStart + 1) + ":D" + (bodyStart + idx) + ")");
        //    lastRow.Cells[3].SetCellFormula("SUM(E" + (bodyStart + 1) + ":E" + (bodyStart + idx) + ")");
        //    lastRow.Cells[4].SetCellFormula("SUM(F" + (bodyStart + 1) + ":F" + (bodyStart + idx) + ")");
        //    lastRow.Cells[5].SetCellFormula("SUM(G" + (bodyStart + 1) + ":G" + (bodyStart + idx) + ")");
        //    lastRow.Cells[6].SetCellFormula("SUM(H" + (bodyStart + 1) + ":H" + (bodyStart + idx) + ")");

        //    return idx;
        //}

        //static public FileStream createHit0DiffExcelReport(IList<RuleVO> ruleList)
        //{

        //    int first = 3;
        //    int bodyStart = 4;

        //    if (!Directory.Exists("export"))
        //    {
        //        System.IO.Directory.CreateDirectory("export");
        //    }

        //    string templateFileName = @"Resources\dupHit0.xls";
        //    string exportFileName = @"export\" + DateTime.Now.ToFileTime() + ".xls";
        //    FileStream templateFs = new FileStream(templateFileName, FileMode.Open, FileAccess.Read);
        //    FileStream fs = new FileStream(exportFileName, FileMode.Create, FileAccess.ReadWrite);

        //    // Getting the complete workbook... 
        //    HSSFWorkbook workbook = new HSSFWorkbook(templateFs, true);
        //    HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(0);

        //    sheet.ForceFormulaRecalculation = true;

        //    templateFs.Close();
        //    templateFs.Dispose();

        //    int idx = 0;
        //    HSSFRow firstRow = (HSSFRow)sheet.GetRow(first);
        //    HSSFRow bodyStartRow = (HSSFRow)sheet.GetRow(bodyStart);
        //    HSSFRow row = null;

        //    foreach (var item in ruleList)
        //    {
        //        row = (idx == 0) ? bodyStartRow : (HSSFRow)bodyStartRow.CopyRowTo(idx + bodyStart);

        //        row.Cells[0].SetCellValue(item.No);
        //        row.Cells[1].SetCellValue(item.InOut);
        //        row.Cells[2].SetCellValue(item.Enabled);
        //        row.Cells[3].SetCellValue(item.Source);
        //        row.Cells[4].SetCellValue(item.User);
        //        row.Cells[5].SetCellValue(item.Destination);
        //        row.Cells[6].SetCellValue(item.Service);
        //        row.Cells[7].SetCellValue(item.Action);
        //        row.Cells[8].SetCellValue(item.Hits);
        //        row.Cells[9].SetCellValue(item.Logging);
        //        row.Cells[10].SetCellValue(item.Time);
        //        row.Cells[11].SetCellValue(item.Description);
        //        idx++;
        //    }
        //    workbook.Write(fs);
        //    return fs;
        //}

    }
}
