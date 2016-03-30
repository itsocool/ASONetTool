using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSH_WinForm.controls
{
    public class HCSummaryVO
    {
        public int AllCount { get; set; }
        public int PassedCount { get; set; }
        public int FailedCount { get; set; }
        public string ExportHtmlFileName { get; set; }
    }
}
