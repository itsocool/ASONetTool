using System;
using System.Collections.Generic;

namespace MSSH_WinForm.controls
{
    public class RuleResultVO
    {
        public DateTime ResultDate { get; set; }
        public int InAnySrcRuleCount { get; set; }
        public int InAnyDestRuleCount { get; set; }
        public int InExpireCount { get; set; }
        public int InRuleCount { get; set; }
        public int inHit0Count { get; set; }
        public int inExeptionCount { get; set; }
        public int OutAnySrcRuleCount { get; set; }
        public int OutAnyDestRuleCount { get; set; }
        public int OutExpireCount { get; set; }
        public int OutRuleCount { get; set; }
        public int OutHit0Count { get; set; }
        public int OutExeptionCount { get; set; }
        public int GloblRuleCount { get; set; }
        public string FileName { get; set; }
        public List<RuleVO> Rules { get; set; }
        public List<RuleVO> Hit0Rules { get; set; }
    }
}
