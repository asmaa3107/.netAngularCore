using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class JobLanguage
    {
        public int JobLanguageId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int FkJobId { get; set; }
        public string LanguageName { get; set; }

        public Job FkJob { get; set; }
    }
}
