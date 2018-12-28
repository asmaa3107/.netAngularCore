using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class GuideDirectoryLanguage
    {
        public int GuideDirectoryLanguageId { get; set; }
        public string GuideDirectoryContent { get; set; }
        public string LanguageName { get; set; }
        public int FkGuideDirectoryId { get; set; }
        public string GuideDirectoryName { get; set; }

        public GuideDirectory FkGuideDirectory { get; set; }
    }
}
