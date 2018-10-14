using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpLog
{
    [Serializable]
    public class Log
    {
        public String TrueName { get; set; }
        public String Alias { get; set; }
        public String OriginalAge { get; set; }
        public String OriginalHeight { get; set; }
        public String OriginalSex { get; set; }
        public String OriginalWeight { get; set; }
        public String OriginalBiography { get; set; }
        public String OriginalAppearence { get; set; }

        
        public String JumperName { get; set; }
        public String JumperAlias { get; set; }
        public String Benefactor { get; set; }
        public String TrueAge { get; set; }
        public String Species { get; set; }
        public String TrueGender { get; set; }
        public String TrueHeight { get; set; }
        public String TrueWeight { get; set; }
        public String HomePlane { get; set; }
        public String TrueVisage { get; set; }
    }
}
