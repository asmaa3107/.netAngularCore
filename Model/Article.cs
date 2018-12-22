using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Article
    {
        public Article()
        {
            ArticleLanguage = new HashSet<ArticleLanguage>();
            MenuItem = new HashSet<MenuItem>();
        }

        public int ArticleId { get; set; }
        public DateTime Aricledate { get; set; }
        public bool IsPublished { get; set; }
        public Guid? FkUserId { get; set; }
        public string ImagePath { get; set; }

        public AspnetUsers FkUser { get; set; }
        public ICollection<ArticleLanguage> ArticleLanguage { get; set; }
        public ICollection<MenuItem> MenuItem { get; set; }
    }
}
