using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class GuideDirectory
    {
        public GuideDirectory()
        {
            GuideDirectoryLanguage = new HashSet<GuideDirectoryLanguage>();
        }

        public int GuideDirectoryId { get; set; }
        public bool IsPublished { get; set; }
        public int FkGuideCategoryId { get; set; }
        public int? GuideDirectoryOrder { get; set; }

        public GuideCategory FkGuideCategory { get; set; }
        public ICollection<GuideDirectoryLanguage> GuideDirectoryLanguage { get; set; }
    }
}
