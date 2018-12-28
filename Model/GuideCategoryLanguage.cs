using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class GuideCategoryLanguage
    {
        public int GuideCategoryLanguageId { get; set; }
        public string GuideCategoryTitle { get; set; }
        public int FkGuideCategoryId { get; set; }
        public string LanguageName { get; set; }

        public GuideCategory FkGuideCategory { get; set; }
    }
}
