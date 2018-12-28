using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class AnswerQuestion
    {
        public AnswerQuestion()
        {
            AnswerLanguage = new HashSet<AnswerLanguage>();
        }

        public int AnswerQuestionId { get; set; }
        public bool Ispublished { get; set; }
        public int? NoOfReplies { get; set; }
        public int FkSurvayQuestionId { get; set; }
        public DateTime AnswerDate { get; set; }
        public int? AnswerOrder { get; set; }

        public SurvayQuestion FkSurvayQuestion { get; set; }
        public ICollection<AnswerLanguage> AnswerLanguage { get; set; }
    }
}
