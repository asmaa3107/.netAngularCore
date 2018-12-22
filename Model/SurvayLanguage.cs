using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class SurvayLanguage
    {
        public int SurvayLanguageId { get; set; }
        public string SurvayHeader { get; set; }
        public string SurvayName { get; set; }
        public string SurvayMessage { get; set; }
        public string LanguageName { get; set; }
        public int FkSurvayId { get; set; }

        public Survay FkSurvay { get; set; }
    }
}
