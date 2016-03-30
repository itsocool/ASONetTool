using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSH_WinForm.controls
{
    class UserVO
    {
        public int No { get; set; }
        public string UserName { get; set; }
        public string Privilege { get; set; }
        public string Secret { get; set; }
        public string Hash { get; set; }
    }
}
