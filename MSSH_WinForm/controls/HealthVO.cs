using System;
using System.Collections.Generic;

namespace MSSH_WinForm.controls
{
    public class HealthVO
    {

        
        public bool HasAuX { get; set; }
        public string HostName { get; set; }
        public string IPAddress { get; set; }
        public string IOSVersion { get; set; }
        public bool OverAll { get; set; }
        // Global Rule check
        public int ServiceTimestampsDebug { get; set; }
        public int ServiceTimestampsLog { get; set; }
        public int ServicePasswordEncryption { get; set; }
        public int EnableSecret { get; set; }
        public int ClockTimezoneKST9 { get; set; }
        public int NoIpSourceRoute { get; set; }
        public int NoServicePad { get; set; }
        public int IpFinger { get; set; }
        public int NoIpHttpServer { get; set; }
        public int BootNetwork { get; set; }
        public int IpMaskReply { get; set; }
        public int NoIpDomain { get; set; }
        public int BannerMotd { get; set; }
        public int NoServiceTcpSmallServers { get; set; }
        public int NoServiceudpSmallServers { get; set; }
        public int AaaAuthenticationLoginDefaultGroup { get; set; }
        public int AaaAuthorizationConsole { get; set; }
        public int AaaAuthenticationExecDefaultGroup { get; set; }
        public int Username { get; set; }
        public int TacacsServerHost_10_129_30_155 { get; set; }
        public int NtpServer { get; set; }
        public int Logging_10_129_10_24 { get; set; }
        public int SnmpServerCommunityRoSnmpAcl { get; set; }
        public int SnmpServerCommunityRw { get; set; }
        public int SnmpServerCommunityPublic { get; set; }
        public int SnmpServerCommunityPrivate { get; set; }
        public int DotServer { get; set; }
        // FastEthernet Rule check
        public int FastEIpDirectedBroadcast { get; set; }
        public int FastEIpMaskReply { get; set; }
        public int FastENoIpRedirects { get; set; }
        public int FastENoIpProxyArp { get; set; }
        public int FastENoIpUnreachables { get; set; }
        // Line con Rule check
        public int LineConPassword7 { get; set; }
        public int LineConExecTimeout_5_0 { get; set; }
        // AUX con Rule check
        public int AuxConNoExec { get; set; }
        public int AuxConExecTimeout_5_0 { get; set; }
        // VTY con Rule check
        public int VtyConPassword7 { get; set; }
        public int VtyConExecTimeout_5_0 { get; set; }
        public int VtyConAccessClass { get; set; }
        public int VtyConTransportInputSsh { get; set; }
        public int VtyConTransportOutputSsh { get; set; }
        public string TimeTable { get; set; }
        public string HtmlRow { get; set; }
    }
}
