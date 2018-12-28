using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class QuestionLanguage
    {
        public int QuestionLanguageId { get; set; }
        public string QuestionContent { get; set; }
        public int FkQuestionId { get; set; }
        public string LanguageName { get; set; }

        public SurvayQuestion FkQuestion { get; set; }
    }
}
