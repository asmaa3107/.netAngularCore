using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class AnswerLanguage
    {
        public int AnswerLanguageId { get; set; }
        public string AnswerContent { get; set; }
        public string LanguageName { get; set; }
        public int FkAnswerId { get; set; }

        public AnswerQuestion FkAnswer { get; set; }
    }
}
