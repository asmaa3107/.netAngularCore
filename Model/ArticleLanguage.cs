using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class ArticleLanguage
    {
        public int ArticleLanguageId { get; set; }
        public int FkArticleId { get; set; }
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Body { get; set; }
        public string LangName { get; set; }

        public Article FkArticle { get; set; }
    }
}
