using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class GuideCategory
    {
        public GuideCategory()
        {
            GuideCategoryLanguage = new HashSet<GuideCategoryLanguage>();
            GuideDirectory = new HashSet<GuideDirectory>();
        }

        public int GuideCategoryId { get; set; }
        public bool IsPublished { get; set; }
        public int? GuideCategoryOrder { get; set; }

        public ICollection<GuideCategoryLanguage> GuideCategoryLanguage { get; set; }
        public ICollection<GuideDirectory> GuideDirectory { get; set; }
    }
}
