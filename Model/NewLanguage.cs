using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class NewLanguage
    {
        public int NewsLanguageId { get; set; }
        public string Title { get; set; }
        public string NewsContent { get; set; }
        public int FkNewsId { get; set; }
        public string LanguageName { get; set; }

        public News FkNews { get; set; }
    }
}
