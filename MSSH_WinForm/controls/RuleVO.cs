using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSH_WinForm.controls
{
    public class RuleVO
    {
        public string No { get; set; }
        public bool Enabled { get; set; }
        public string InOut { get; set; }
        public string Source { get; set; }
        public string User { get; set; }
        public string Destination { get; set; }
        public string Service { get; set; }
        public string Action { get; set; }
        public long Hits { get; set; }
        public string Logging { get; set; }
        public string Time { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Description { get; set; }
        public string SecurityGroup { get; set; }
        public List<string> SourceList { get; set; }
        public List<string> DestinationList { get; set; }
        public List<string> ServiceList { get; set; }
    }
}
