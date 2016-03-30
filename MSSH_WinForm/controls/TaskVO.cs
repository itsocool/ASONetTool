using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSH_WinForm.controls
{
    public class TaskVO
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string WorkingDir { get; set; }
        public string DefaultSSHId { get; set; }
        public string DefaultSSHPassword { get; set; }
        public int DefaultSSHPort { get; set; }
        public string AutoExitYN { get; set; }
        public int MaxConnections { get; set; }
        public int ConnectionTimeOut { get; set; }
        public string CommandList { get; set; }
        public List<HostVO> HostList { get; set; }
    }
}
