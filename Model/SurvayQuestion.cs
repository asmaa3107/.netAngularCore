using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class SurvayQuestion
    {
        public SurvayQuestion()
        {
            AnswerQuestion = new HashSet<AnswerQuestion>();
            QuestionLanguage = new HashSet<QuestionLanguage>();
        }

        public int QuestionId { get; set; }
        public bool QuestionIsPublished { get; set; }
        public DateTime QuestionDate { get; set; }
        public int QuestionOrder { get; set; }
        public int FkSurvayId { get; set; }

        public Survay FkSurvay { get; set; }
        public ICollection<AnswerQuestion> AnswerQuestion { get; set; }
        public ICollection<QuestionLanguage> QuestionLanguage { get; set; }
    }
}
