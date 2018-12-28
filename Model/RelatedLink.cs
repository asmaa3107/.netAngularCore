using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class RelatedLink
    {
        public RelatedLink()
        {
            RelatedLinkLanguage = new HashSet<RelatedLinkLanguage>();
        }

        public int RelatedLinkId { get; set; }
        public bool Ispublished { get; set; }
        public DateTime RelatedLinkDate { get; set; }
        public string RelatedLinkUrl { get; set; }
        public int? RelatedLinkOrder { get; set; }

        public ICollection<RelatedLinkLanguage> RelatedLinkLanguage { get; set; }
    }
}
