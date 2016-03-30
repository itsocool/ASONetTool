using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSH_WinForm.controls
{
    public class HostVO
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public int MaxConnections { get; set; }
        public int ConnectionTimeOut { get; set; }
        public string CommandList { get; set; }

        public string Host { get; set; }
        public string Type { get; set; }
        public string UserId { get; set; }
        public string UserPassword { get; set; }
        public int Port { get; set; }
        public string Remark { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool Connected { get; set; }
        public bool Athenticated { get; set; }
        public bool Completed { get; set; }
        public bool OnError { get; set; }
        public string Error { get; set; }
        public string Result { get; set; }
        public string ResultFileName { get; set; }
        public string ResultDir { get; set; }
        public string EquipName { get; set; }
        public HealthVO HealthVO { get; set; }
    }
}
