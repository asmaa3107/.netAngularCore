using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class News
    {
        public News()
        {
            NewLanguage = new HashSet<NewLanguage>();
        }

        public int NewsId { get; set; }
        public string NewsDate { get; set; }
        public bool IsPublished { get; set; }
        public int? NewsOrder { get; set; }
        public int? FkCompId { get; set; }

        public ICollection<NewLanguage> NewLanguage { get; set; }
    }
}
