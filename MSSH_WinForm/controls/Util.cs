using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSH_WinForm.controls
{
    public class Util
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Util));

        public List<HealthVO> ParsingHealthChek(List<DataGridViewRow> value)
        {
            List<HealthVO> result = null;

            if (value != null && value.Count > 0)
            {
                result = new List<HealthVO>();

                foreach (var row in value)
                {
                    HealthVO vo = ParseRow(row);
                    if(vo == null)
                    {
                        vo = new HealthVO();
                    }

                    if (!string.IsNullOrWhiteSpace(vo.HostName))
                    {
                        row.Cells["healthCheck"].Value = vo;
                    }

                    vo.IPAddress = row.Cells["host"].Value.ToString();

                    result.Add(vo);
                }
            }

            return result;
        }

        public List<HealthVO> ParsingHealthChek(List<DataRowView> value)
        {
            List<HealthVO> result = null;

            if (value != null && value.Count > 0)
            {
                result = new List<HealthVO>();

                foreach (var row in value)
                {
                    HealthVO vo = ParseRow(row);
                    if (vo == null)
                    {
                        vo = new HealthVO();
                    }

                    if (!string.IsNullOrWhiteSpace(vo.HostName))
                    {
                        row["healthCheck"] = vo;
                    }

                    vo.IPAddress = row["host"].ToString();

                    result.Add(vo);
                }
            }

            return result;
        }

        private HealthVO ParseRow(DataGridViewRow row)
        {
            HealthVO vo = new HealthVO();
            string text = row.Cells["logText"].Value as string;

            try
            {
                vo.HasAuX = (Find("PID: WS-", text) > 0) ? false : true;
                vo.IPAddress = row.Cells["host"].Value as string;
                vo.HostName = row.Cells["equipName"].Value as string;
                vo.IOSVersion = GetMatchedString("(, Version )([^,]+)(,)", text, 2);

                // service timestamps debug,Not Found(Fail)
                // service timestamps log,Not Found(Fail)
                // service password-encryption,Not Found(Fail)
                // enable secret,Not Found(Pass)
                // clock timezone KST 9,Not Found(Fail)
                // no ip source-route,Not Found(Fail)
                // no service pad,Not Found(Fail)
                // ip finger,Not Found(Pass)
                // no ip http server,Not Found(Fail)
                // boot network,Not Found(Pass)
                // ip mask-reply,Not Found(Pass)
                // no ip domain,Not Found(Fail)
                // banner motd,Not Found(Fail)
                // no service tcp-small-servers,Not Found(Pass)
                // no service udp-small-servers,Not Found(Pass)
                // aaa authentication login default group tacacs\+ local,Not Found(Fail)
                // aaa authorization console,Not Found(Fail)
                // aaa authorization exec default group tacacs\+ local ,Not Found(Fail)
                // username,Not Found(Fail)
                // tacacs-server host 10.129.30.155,Not Found(Fail)
                // ntp server,Not Found(Fail)
                // logging 10.129.10.24,Not Found(Fail)
                // snmp-server community Opas/IBM/Am5re RO SNMP_ACL,Not Found(Fail)
                // snmp-server community Opas/IBM/Am5re RW,Not Found(Pass)
                // snmp-server community public,Not Found(Pass)
                // snmp-server community private,Not Found(Pass)
                // banner motd,Not Found(Fail)
                // .server,Not Found(Fail)

                vo.ServiceTimestampsDebug = Find("service timestamps debug", text);
                vo.ServiceTimestampsLog = Find("service timestamps log", text);
                vo.ServicePasswordEncryption = Find("service password-encryption", text);
                vo.EnableSecret = Find("enable secret", text);
                vo.ClockTimezoneKST9 = Find("clock timezone KST 9", text);
                vo.NoIpSourceRoute = Find("no ip source-route", text);
                vo.NoServicePad = Find("no service pad", text);
                vo.IpFinger = Find("ip finger", text);
                vo.NoIpHttpServer = Find("no ip http server", text);
                vo.BootNetwork = Find("boot network", text);
                vo.IpMaskReply = Find("ip mask-reply", text);
                vo.NoIpDomain = Find("no ip domain", text);
                vo.BannerMotd = Find("banner motd", text);
                vo.NoServiceTcpSmallServers = Find("no service tcp-small-servers", text);
                vo.NoServiceudpSmallServers = Find("no service udp-small-servers", text);
                vo.AaaAuthenticationLoginDefaultGroup = Find(@"aaa authentication login default group tacacs+ local", text);
                vo.AaaAuthorizationConsole = Find("aaa authorization console", text);
                vo.AaaAuthenticationExecDefaultGroup = Find(@"aaa authorization exec default group tacacs+ local", text);
                vo.Username = Find("username", text);
                vo.TacacsServerHost_10_129_30_155 = Find("tacacs-server host 10.129.30.155", text);
                vo.NtpServer = Find("ntp server", text);
                vo.Logging_10_129_10_24 = FindRegEx("logging .* 10.129.10.24", text);
                vo.SnmpServerCommunityRoSnmpAcl = Find("snmp-server community Opas/IBM/Am5re RO SNMP_ACL", text);
                vo.SnmpServerCommunityRw = Find("snmp-server community Opas/IBM/Am5re RW", text);
                vo.SnmpServerCommunityPublic = Find("snmp-server community public", text);
                vo.SnmpServerCommunityPrivate = Find("snmp-server community private", text);
                vo.DotServer = Find(".server", text);

                vo.FastEIpDirectedBroadcast = Find("ip directed-broadcast", text);
                vo.FastEIpMaskReply = Find("ip mask-reply", text);
                vo.FastENoIpRedirects = Find("no ip redirects", text);
                vo.FastENoIpProxyArp = Find("no ip proxy-arp", text);
                vo.FastENoIpUnreachables = Find("no ip unreachables", text);

                int conIndex = text.IndexOf("line con");
                int auxIndex = text.IndexOf("line aux");
                int vtyIndex = text.IndexOf("line vty");

                auxIndex = (vo.HasAuX) ? auxIndex : vtyIndex;

                if(conIndex > 0 && conIndex < text.Length && auxIndex > conIndex && auxIndex < text.Length)
                {
                    vo.LineConPassword7 = Find("password 7", text, conIndex, auxIndex - conIndex - 1);
                    vo.LineConExecTimeout_5_0 = Find("exec-timeout 5 0", text, conIndex, auxIndex - conIndex - 1);
                }else
                {
                    vo.LineConPassword7 = -1;
                    vo.LineConExecTimeout_5_0 = -1;
                }

                if (vo.HasAuX)
                {
                    if (auxIndex > 0 && auxIndex < text.Length && vtyIndex > auxIndex && vtyIndex < text.Length)
                    {
                        vo.AuxConNoExec = Find("no exec", text, auxIndex, vtyIndex - auxIndex - 1);
                        vo.AuxConExecTimeout_5_0 = Find("exec-timeout 5 0", text, auxIndex, vtyIndex - auxIndex - 1);
                    }else
                    {
                        vo.AuxConNoExec = -1;
                        vo.AuxConExecTimeout_5_0 = -1;
                    }
                }

                if(vtyIndex > 0 && vtyIndex < text.Length)
                {
                    vo.VtyConPassword7 = Find("password 7", text, vtyIndex, text.Length - vtyIndex - 1);
                    vo.VtyConExecTimeout_5_0 = Find("exec-timeout 5 0", text, vtyIndex, text.Length - vtyIndex - 1);
                }else
                {
                    vo.VtyConPassword7 = -1;
                    vo.VtyConExecTimeout_5_0 = -1;
                }

                vo.VtyConAccessClass = Find("access-class", text);
                vo.VtyConTransportInputSsh = Find("transport input ssh", text);
                vo.VtyConTransportOutputSsh = Find("transport output ssh", text);
                vo.TimeTable = GetMatchedString(@"(\*?)(\d{2}:\d{2}:\d{2}\.\d{3} [^\r\n]+)", text, 2);

                if (string.IsNullOrWhiteSpace(vo.TimeTable))
                {
                    vo.TimeTable = "N/A";
                }
                else
                {
                    try
                    {
                        string timeString = GetMatchedString(@"(\*?)(\d{2}:\d{2}:\d{2})", text, 2);
                        string dateString = GetMatchedString(@"(\*?\d{2}:\d{2}:\d{2}\.\d{3} )([^\r\n]+)", text, 2);
                        string[] timeparts = dateString.Split(new char[] { ' ' });
                        dateString = string.Join(" ", timeparts, 2, 3);
                        DateTime dt = DateTime.Parse(timeString + dateString);
                        vo.TimeTable = dt.ToString("yyyy-MM-dd hh:mm:ss");
                    }
                    catch
                    {
                        vo.TimeTable = "N/A";
                    }
                }

                //CultureInfo culture = new CultureInfo("en-US");
                //DateTimeStyles styles = DateTimeStyles.None;
                //DateTime dt = new DateTime();
                //string format = "hh:mm:dd.fff KST ddd MMM dd yyyy";
                //if (!string.IsNullOrWhiteSpace(vo.TimeTable) && DateTime.TryParseExact(vo.TimeTable, format, culture, styles, out dt))
                //{
                //    vo.TimeTable = dt.ToString("yyyy-MM-dd hh:mm:ss");
                //}else
                //{
                //    vo.TimeTable = "N/A";
                //}
            }
            catch (Exception ex)
            {
                logger.Error( "health check vo pasing error", ex);
                vo.HostName = null;
            }

            return vo;
        }

        private HealthVO ParseRow(DataRowView row)
        {
            HealthVO vo = new HealthVO();
            string text = row["logText"] as string;

            try
            {
                vo.HasAuX = (Find("PID: WS-", text) > 0) ? false : true;
                vo.IPAddress = row["host"] as string;
                vo.HostName = row["equipName"] as string;
                vo.IOSVersion = GetMatchedString("(, Version )([^,]+)(,)", text, 2);

                // service timestamps debug,Not Found(Fail)
                // service timestamps log,Not Found(Fail)
                // service password-encryption,Not Found(Fail)
                // enable secret,Not Found(Pass)
                // clock timezone KST 9,Not Found(Fail)
                // no ip source-route,Not Found(Fail)
                // no service pad,Not Found(Fail)
                // ip finger,Not Found(Pass)
                // no ip http server,Not Found(Fail)
                // boot network,Not Found(Pass)
                // ip mask-reply,Not Found(Pass)
                // no ip domain,Not Found(Fail)
                // banner motd,Not Found(Fail)
                // no service tcp-small-servers,Not Found(Pass)
                // no service udp-small-servers,Not Found(Pass)
                // aaa authentication login default group tacacs\+ local,Not Found(Fail)
                // aaa authorization console,Not Found(Fail)
                // aaa authorization exec default group tacacs\+ local ,Not Found(Fail)
                // username,Not Found(Fail)
                // tacacs-server host 10.129.30.155,Not Found(Fail)
                // ntp server,Not Found(Fail)
                // logging 10.129.10.24,Not Found(Fail)
                // snmp-server community Opas/IBM/Am5re RO SNMP_ACL,Not Found(Fail)
                // snmp-server community Opas/IBM/Am5re RW,Not Found(Pass)
                // snmp-server community public,Not Found(Pass)
                // snmp-server community private,Not Found(Pass)
                // banner motd,Not Found(Fail)
                // .server,Not Found(Fail)

                vo.ServiceTimestampsDebug = Find("service timestamps debug", text);
                vo.ServiceTimestampsLog = Find("service timestamps log", text);
                vo.ServicePasswordEncryption = Find("service password-encryption", text);
                vo.EnableSecret = Find("enable secret", text);
                vo.ClockTimezoneKST9 = Find("clock timezone KST 9", text);
                vo.NoIpSourceRoute = Find("no ip source-route", text);
                vo.NoServicePad = Find("no service pad", text);
                vo.IpFinger = Find("ip finger", text);
                vo.NoIpHttpServer = Find("no ip http server", text);
                vo.BootNetwork = Find("boot network", text);
                vo.IpMaskReply = Find("ip mask-reply", text);
                vo.NoIpDomain = Find("no ip domain", text);
                vo.BannerMotd = Find("banner motd", text);
                vo.NoServiceTcpSmallServers = Find("no service tcp-small-servers", text);
                vo.NoServiceudpSmallServers = Find("no service udp-small-servers", text);
                vo.AaaAuthenticationLoginDefaultGroup = Find(@"aaa authentication login default group tacacs+ local", text);
                vo.AaaAuthorizationConsole = Find("aaa authorization console", text);
                vo.AaaAuthenticationExecDefaultGroup = Find(@"aaa authorization exec default group tacacs+ local", text);
                vo.Username = Find("username", text);
                vo.TacacsServerHost_10_129_30_155 = Find("tacacs-server host 10.129.30.155", text);
                vo.NtpServer = Find("ntp server", text);
                vo.Logging_10_129_10_24 = FindRegEx("logging .* 10.129.10.24", text);
                vo.SnmpServerCommunityRoSnmpAcl = Find("snmp-server community Opas/IBM/Am5re RO SNMP_ACL", text);
                vo.SnmpServerCommunityRw = Find("snmp-server community Opas/IBM/Am5re RW", text);
                vo.SnmpServerCommunityPublic = Find("snmp-server community public", text);
                vo.SnmpServerCommunityPrivate = Find("snmp-server community private", text);
                vo.DotServer = Find(".server", text);

                vo.FastEIpDirectedBroadcast = Find("ip directed-broadcast", text);
                vo.FastEIpMaskReply = Find("ip mask-reply", text);
                vo.FastENoIpRedirects = Find("no ip redirects", text);
                vo.FastENoIpProxyArp = Find("no ip proxy-arp", text);
                vo.FastENoIpUnreachables = Find("no ip unreachables", text);

                int conIndex = text.IndexOf("line con");
                int auxIndex = text.IndexOf("line aux");
                int vtyIndex = text.IndexOf("line vty");

                auxIndex = (vo.HasAuX) ? auxIndex : vtyIndex;

                if (conIndex > 0 && conIndex < text.Length && auxIndex > conIndex && auxIndex < text.Length)
                {
                    vo.LineConPassword7 = Find("password 7", text, conIndex, auxIndex - conIndex - 1);
                    vo.LineConExecTimeout_5_0 = Find("exec-timeout 5 0", text, conIndex, auxIndex - conIndex - 1);
                }
                else
                {
                    vo.LineConPassword7 = -1;
                    vo.LineConExecTimeout_5_0 = -1;
                }

                if (vo.HasAuX)
                {
                    if (auxIndex > 0 && auxIndex < text.Length && vtyIndex > auxIndex && vtyIndex < text.Length)
                    {
                        vo.AuxConNoExec = Find("no exec", text, auxIndex, vtyIndex - auxIndex - 1);
                        vo.AuxConExecTimeout_5_0 = Find("exec-timeout 5 0", text, auxIndex, vtyIndex - auxIndex - 1);
                    }
                    else
                    {
                        vo.AuxConNoExec = -1;
                        vo.AuxConExecTimeout_5_0 = -1;
                    }
                }

                if (vtyIndex > 0 && vtyIndex < text.Length)
                {
                    vo.VtyConPassword7 = Find("password 7", text, vtyIndex, text.Length - vtyIndex - 1);
                    vo.VtyConExecTimeout_5_0 = Find("exec-timeout 5 0", text, vtyIndex, text.Length - vtyIndex - 1);
                }
                else
                {
                    vo.VtyConPassword7 = -1;
                    vo.VtyConExecTimeout_5_0 = -1;
                }

                vo.VtyConAccessClass = Find("access-class", text);
                vo.VtyConTransportInputSsh = Find("transport input ssh", text);
                vo.VtyConTransportOutputSsh = Find("transport output ssh", text);
                vo.TimeTable = GetMatchedString(@"(\*?)(\d{2}:\d{2}:\d{2}\.\d{3} [^\r\n]+)", text, 2);

                if (string.IsNullOrWhiteSpace(vo.TimeTable))
                {
                    vo.TimeTable = "N/A";
                }
                else
                {
                    try
                    {
                        string timeString = GetMatchedString(@"(\*?)(\d{2}:\d{2}:\d{2})", text, 2);
                        string dateString = GetMatchedString(@"(\*?\d{2}:\d{2}:\d{2}\.\d{3} )([^\r\n]+)", text, 2);
                        string[] timeparts = dateString.Split(new char[] { ' ' });
                        dateString = string.Join(" ", timeparts, 2, 3);
                        DateTime dt = DateTime.Parse(timeString + dateString);
                        vo.TimeTable = dt.ToString("yyyy-MM-dd hh:mm:ss");
                    }
                    catch
                    {
                        vo.TimeTable = "N/A";
                    }
                }

                //CultureInfo culture = new CultureInfo("en-US");
                //DateTimeStyles styles = DateTimeStyles.None;
                //DateTime dt = new DateTime();
                //string format = "hh:mm:dd.fff KST ddd MMM dd yyyy";
                //if (!string.IsNullOrWhiteSpace(vo.TimeTable) && DateTime.TryParseExact(vo.TimeTable, format, culture, styles, out dt))
                //{
                //    vo.TimeTable = dt.ToString("yyyy-MM-dd hh:mm:ss");
                //}else
                //{
                //    vo.TimeTable = "N/A";
                //}
            }
            catch (Exception ex)
            {
                logger.Error( "health check vo pasing error", ex);
                vo.HostName = null;
            }

            return vo;
        }

        private int Find(string pattern, string text)
        {
            // -1   : Not found
            // 1    : Found
            int result = 0;
            result = (text.IndexOf(pattern) > 0) ? 1 : -1;
            return result;
        }

        private int Find(string pattern, string text, int startIndex, int count)
        {
            // -1   : Not found
            // 1    : Found
            int result = 0;
            result = (text.IndexOf(pattern, startIndex, count) > 0) ? 1 : -1;
            return result;
        }

        private int FindRegEx(string pattern, string text)
        {
            // -1   : Not found
            // 1    : Found
            int result = 0;
            Regex reg = new Regex(pattern);
            result = (reg.Match(pattern).Success) ? 1 : -1;

            return result;
        }


        private string GetMatchedString(string pattern, string str, int idx)
        {
            Regex reg = new Regex(pattern, RegexOptions.Multiline | RegexOptions.IgnoreCase);
            string result = null;
            Match match = reg.Match(str);

            if (match != null && match.Success && match.Groups.Count > idx)
            {
                result = match.Groups[idx].Value;
            }

            return result;
        }

        public HCSummaryVO makeHtml(List<HealthVO> list)
        {
            HCSummaryVO vo = new HCSummaryVO();
            vo.AllCount = 0;
            vo.PassedCount = 0;
            vo.FailedCount = 0;
            vo.ExportHtmlFileName = "";

            try
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(@"Resources\HealthCheckResult.html");

                HtmlAgilityPack.HtmlNode passNode = doc.DocumentNode.SelectSingleNode("//tr[@class='passRow']");
                HtmlAgilityPack.HtmlNodeCollection passNodeTd = passNode.SelectNodes("td");
                HtmlAgilityPack.HtmlNode failNode = doc.DocumentNode.SelectSingleNode("//tr[@class='failRow']");
                HtmlAgilityPack.HtmlNodeCollection failNodeTd = failNode.SelectNodes("td");
                HtmlAgilityPack.HtmlNode naNode = doc.DocumentNode.SelectSingleNode("//tr[@class='naRow']");
                HtmlAgilityPack.HtmlNodeCollection naNodeTd = failNode.SelectNodes("td");
                HtmlAgilityPack.HtmlNode table = doc.DocumentNode.SelectSingleNode("//table");
                HtmlAgilityPack.HtmlNode newRow = null;

                int idx = 0;

                vo.AllCount = list.Count;

                foreach (var item in list)
                {
                    bool overAll = true;


                    newRow = HtmlAgilityPack.HtmlNode.CreateNode(passNode.OuterHtml);
                    HtmlAgilityPack.HtmlNodeCollection newTdList = newRow.SelectNodes("td");
                    PropertyInfo[] properties = item.GetType().GetProperties();

                    if (item == null || string.IsNullOrWhiteSpace(item.HostName))
                    {
                        newRow.InnerHtml = naNode.InnerHtml;
                        newTdList = newRow.SelectNodes("td");
                        newTdList[0].InnerHtml = (idx + 1).ToString();
                        newTdList[2].InnerHtml = string.IsNullOrWhiteSpace(item.IPAddress) ? "N/A" : item.IPAddress;
                        overAll = false;
                    }else
                    { 
                        for (int i = 0; i < newTdList.Count; i++)
                        {
                            PropertyInfo prop = properties[i];
                            string propName = prop.Name;
                            string value = prop.GetValue(item).ToString();


                            if (propName == "HtmlRow")
                            {
                                //item.HtmlRow = newRow.OuterHtml;
                            } else if (propName == "HasAuX")
                            {
                                newTdList[0].InnerHtml = (idx + 1).ToString();
                            }
                            else if (propName == "TimeTable")
                            {
                                newTdList[i].InnerHtml = item.TimeTable;

                                if (item.TimeTable == "N/A")
                                {
                                    newTdList[i].SetAttributeValue("class", "resultBody grayBG");
                                }
                            }
                            else if (i < 4)
                            {
                                newTdList[i].InnerHtml = value;
                            }
                            else if (i > 4)
                            {
                                string rowID = (value == "1") ? "one" : "two";
                                string failTdId = failNodeTd[i].Attributes["headers"].Value;

                                if (!item.HasAuX && "AuxConNoExec".Equals(propName))
                                {
                                    newTdList[i].InnerHtml = "N/A";
                                    newTdList[i].SetAttributeValue("class", "resultBody grayBG");
                                    newTdList[i].SetAttributeValue("colspan", "2");
                                }
                                else if (!item.HasAuX && "AuxConExecTimeout_5_0".Equals(propName))
                                {
                                    newTdList[i].Remove();
                                }
                                else if (rowID.Equals(failTdId))
                                {
                                    overAll = false;
                                    newTdList[i].SetAttributeValue("class", failNodeTd[i].Attributes["class"].Value);
                                    newTdList[i].InnerHtml = failNodeTd[i].InnerHtml;
                                }
                            }
                        }

                    }

                    HtmlAgilityPack.HtmlNode overAllNode = newTdList[4];

                    if (!overAll)
                    {
                        item.OverAll = false;
                        overAllNode.SetAttributeValue("class", "resultBody redFont");
                        overAllNode.InnerHtml = "Failed";
                    }
                    else
                    {
                        item.OverAll = true;
                        vo.PassedCount++;
                    }

                    item.HtmlRow = newRow.OuterHtml;

                    table.AppendChild(newRow);
                    idx++;
                }

                passNode.Remove();
                failNode.Remove();
                naNode.Remove();

                string fileName = @"export\HC_result" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".html";//_hhmmssff
                vo.FailedCount = vo.AllCount - vo.PassedCount;
                vo.ExportHtmlFileName = fileName;
                doc.Save(fileName);
                doc = null;
            }
            catch (Exception ex)
            {
                logger.Error( "HC result error", ex);
            }

            return vo;
        }
    }
}
