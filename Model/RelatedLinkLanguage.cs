using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class RelatedLinkLanguage
    {
        public int RelatedLinkLanguageId { get; set; }
        public string RelatedLinkTitle { get; set; }
        public string LanguageName { get; set; }
        public int FkRelatedLinkId { get; set; }

        public RelatedLink FkRelatedLink { get; set; }
    }
}
