using SelectPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MSSH_WinForm.controls
{
    public class HtmlHelper
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(HtmlHelper));

        public static RuleResultVO OpenHtml(DateTime date, string filename)
        {
            List<RuleVO> rules = null;
            List<RuleVO> hit0Rules = null;
            RuleResultVO result = new RuleResultVO();

            if (!string.IsNullOrWhiteSpace(filename))
            {
                result.FileName = Path.GetFileName(filename);
                rules = new List<RuleVO>();
                Uri uri = new System.Uri(filename);
                string url = uri.AbsoluteUri;
                string dir = Path.GetDirectoryName(filename);
                string fileName = Path.GetFileNameWithoutExtension(filename);

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(filename);
                HtmlAgilityPack.HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//tr");

                int idx = 0;

                result.GloblRuleCount = 0;
                result.InAnySrcRuleCount = 0;
                result.InAnyDestRuleCount = 0;
                result.inExeptionCount = 0;
                result.InExpireCount = 0;
                result.inHit0Count = 0;
                result.InRuleCount = 0;
                result.OutAnySrcRuleCount = 0;
                result.OutAnyDestRuleCount = 0;
                result.OutExeptionCount = 0;
                result.OutExpireCount = 0;
                result.OutHit0Count = 0;
                result.OutRuleCount = 0;
                result.ResultDate = date;

                string inOrOut = null; // IN 또는 OUT
                string[] colNames = new string[nodes[0].ChildNodes.Count];

                foreach (HtmlAgilityPack.HtmlNode col in nodes[0].ChildNodes)
                {
                    if (!string.IsNullOrWhiteSpace(col.InnerText))
                    {
                        colNames[idx] = col.InnerText.Trim();
                    }

                    idx++;
                }

                for (int i = 0; i < nodes.Count; i++)
                {
                    HtmlAgilityPack.HtmlNode node = nodes[i];

                    if (node.FirstChild.InnerText == "#")    // Header는 처리 안함
                    {
                        continue;
                    }

                    if (node.ChildNodes.Count < idx) // inside 또는 outside
                    {
                        string str = node.FirstChild.InnerText;
                        str = str.Replace("(", "").Replace(")", "").Trim();
                        string[] arr = str.Split(' ');
                        inOrOut = arr[0].ToLower().Trim();

                        if (arr[0].ToLower() == "inside")
                        {
                            result.InRuleCount = Convert.ToInt32(arr[1]);
                        }
                        else if (arr[0].ToLower() == "outside")
                        {
                            result.OutRuleCount = Convert.ToInt32(arr[1]);
                        }
                        else
                        {
                            result.GloblRuleCount = Convert.ToInt32(arr[1]);
                        }
                    }
                    else
                    {
                        RuleVO rule = new RuleVO();

                        for (int nodeIdx = 0; nodeIdx < node.ChildNodes.Count; nodeIdx++)
                        {
                            HtmlAgilityPack.HtmlNode childNode = node.ChildNodes[nodeIdx];
                            string text = childNode.InnerText;
                            string html = childNode.InnerHtml;

                            string tdValue = null;

                            if (string.IsNullOrWhiteSpace(text))
                            {
                                text = "";
                            }
                            else
                            {
                                text = text.Replace("&nbsp;", " ");
                                text = WebUtility.HtmlDecode(text).Trim();
                            }

                            if (string.IsNullOrWhiteSpace(html))
                            {
                                html = "";
                            }

                            switch (colNames[nodeIdx])
                            {
                                // #, Enabled, Source, User, Destination, Service, Action, Hits, Logging, Time, Description, Security Group, Security Group 
                                case "#":
                                    tdValue = text;
                                    rule.No = tdValue;
                                    break;
                                case "Enabled":
                                    tdValue = text;
                                    rule.Enabled = (tdValue.ToLower() == "true");
                                    break;
                                case "Source":
                                    tdValue = html;
                                    rule.Source = tdValue.Replace("<br>", ",");
                                    rule.SourceList = getList(tdValue);
                                    break;
                                case "User":
                                    tdValue = text;
                                    rule.User = tdValue;
                                    break;
                                case "Destination":
                                    tdValue = html;
                                    rule.Destination = tdValue.Replace("<br>", ",");
                                    rule.DestinationList = getList(tdValue);
                                    break;
                                case "Service":
                                    tdValue = html;
                                    rule.Service = tdValue.Replace("<br>", ",");
                                    rule.ServiceList = getList(tdValue);
                                    break;
                                case "Action":
                                    tdValue = text;
                                    rule.Action = tdValue;
                                    break;
                                case "Hits":
                                    tdValue = text;
                                    rule.Hits = string.IsNullOrWhiteSpace(tdValue) ? 0 : Convert.ToInt64(tdValue);
                                    break;
                                case "Logging":
                                    tdValue = text;
                                    rule.Logging = tdValue;
                                    break;
                                case "Time":
                                    tdValue = text;
                                    rule.Time = tdValue;
                                    break;
                                case "Description":
                                    tdValue = text;
                                    rule.Description = tdValue;
                                    rule.ExpireDate = getExpireDate(tdValue);
                                    break;
                                case "Security Group":
                                    tdValue = text;
                                    rule.SecurityGroup = tdValue;
                                    break;
                            }
                        }

                        rule.InOut = inOrOut;
                        rules.Add(rule);

                        if(rule.Hits == 0)
                        {
                            if(hit0Rules == null)
                            {
                                hit0Rules = new List<RuleVO>();
                            }

                            hit0Rules.Add(rule);
                        }

                        if (inOrOut == "inside")
                        {
                            if (rule.Hits == 0)
                            {
                                result.inHit0Count++;
                            }

                            if (rule.ExpireDate != null && rule.ExpireDate.Year == date.Year && rule.ExpireDate.Month == date.Month)
                            {
                                result.InExpireCount++;
                            }

                            if (rule.Service.ToUpper().Trim() != "ICMP" && rule.Action.ToUpper().Trim() != "DENY" && rule.Source.ToUpper().Trim() == "ANY")
                            {
                                result.InAnySrcRuleCount ++;
                            }

                            if (rule.Service.ToUpper().Trim() != "ICMP" && rule.Action.ToUpper().Trim() != "DENY" && rule.Destination.ToUpper().Trim() == "ANY")
                            {
                                result.InAnyDestRuleCount ++;
                            }
                        }
                        else if (inOrOut == "outside")
                        {
                            if (rule.Hits == 0)
                            {
                                result.OutHit0Count++;
                            }

                            if (rule.ExpireDate != null && rule.ExpireDate.Year == 2015 && rule.ExpireDate.Month == 5)
                            {
                                result.OutExpireCount++;
                            }

                            if (rule.Service.ToUpper().Trim() != "ICMP" && rule.Action.ToUpper().Trim() != "DENY" && rule.Source.ToUpper().Trim() == "ANY")
                            {
                                result.OutAnySrcRuleCount ++;
                            }

                            if (rule.Service.ToUpper().Trim() != "ICMP" && rule.Action.ToUpper().Trim() != "DENY" && rule.Destination.ToUpper().Trim() == "ANY")
                            {
                                result.OutAnyDestRuleCount ++;
                            }
                        }
                        else
                        {
                            result.GloblRuleCount++;
                        }
                    }
                }

                doc = null;
                result.Rules = rules;
                result.Hit0Rules = hit0Rules;
            }
            else
            {
                MessageBox.Show("해당 파일을 찾을수 없습니다.");
            }

            return result;
        }

        static public RuleResultVO OpenHtml(DateTime date)
        {
            RuleResultVO result = null;
            try
            {
                string storedDir = Properties.Settings.Default.RULE_IMPORT_DIR;
                string defaultDir = Path.GetDirectoryName(Application.ExecutablePath);
                storedDir = string.IsNullOrWhiteSpace(storedDir) ? defaultDir : storedDir;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = false;
                dialog.InitialDirectory = storedDir;
                dialog.Filter = "HTML (*.html;*.htm)|*.html;*.htm|AllFiles(*.*)|*.*";
                dialog.Title = "HTML 파일을 선택해 주세요";
                result = new RuleResultVO();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    result = OpenHtml(date, dialog.FileName);
                    Properties.Settings.Default.RULE_IMPORT_DIR = Path.GetDirectoryName(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                logger.Debug("html open error", ex);
                throw;
            }

            return result;
        }

        private static List<string> getList(string tdValue)
        {
            List<string> result = null;

            if(!string.IsNullOrWhiteSpace(tdValue))
            {
                string[] spliter = new string[] { "<br>", "<br/>", "<br />"};
                string[] arr = null;
                result = new List<string>();
                arr = tdValue.Split(spliter, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i].Trim();
                }
                
                result.AddRange(tdValue.Split(spliter, StringSplitOptions.RemoveEmptyEntries).ToList<string>());
            }

            return result;
        }

        static public void Html2Pdf(string htmlFileName, string pdfFileName)
        {
            HtmlToPdf converter = new HtmlToPdf();
            string htmlString = File.ReadAllText(htmlFileName);
            converter.Options.AutoFitWidth = HtmlToPdfPageFitMode.ShrinkOnly;
            converter.Options.PdfPageSize = PdfPageSize.A3;
            converter.Options.PdfPageOrientation = PdfPageOrientation.Landscape;

            PdfDocument pdfDoc = converter.ConvertHtmlString(htmlString);
            pdfDoc.ViewerPreferences.PageLayout = PdfViewerPageLayout.SinglePage;

            pdfDoc.Save(pdfFileName);
        }

        static public DateTime getExpireDate(string desc)
        {
            DateTime result = DateTime.MinValue;
            try
            {
                Regex rgx = new Regex(@"(expire\s*)(\d{4}-\d{2}-\d{2})", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                Match m = rgx.Match(desc);
                string matchString = null;

                if (m.Success && m.Groups.Count > 2)
                {
                    matchString = m.Groups[2].Value;

                    if (!string.IsNullOrWhiteSpace(matchString) && matchString.Length == 10)
                    {
                        result = DateTime.Parse(matchString);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.Out.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
