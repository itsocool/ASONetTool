using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSSH_WinForm.controls
{
    class StandardConfigParser
    {
        public static string ParseHost(string input)
        {
            string result = null;

            if (!string.IsNullOrWhiteSpace(input))
            {
                string pattern = @"(hostname )(.+)\r?$";

                RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Multiline;

                Match match = Regex.Match(input, pattern, options);
                //Console.WriteLine("#########  {0}, {1}, ", match.Groups[0].Value, match.Groups[1].Value);
                if(match != null && match.Groups.Count == 3)
                {
                    result = match.Groups[2].Value.Trim();
                }
            }

            return result;
        }
    }
}
