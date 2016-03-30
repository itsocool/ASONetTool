using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSSH_WinForm.controls
{
    class ConfigVO
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string UserId { get; set; }
        public string UserPassword { get; set; }
        public string CommandList { get; set; }
        public string OutputText { get; set; }
    }
}
