using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Survay
    {
        public Survay()
        {
            SurvayLanguage = new HashSet<SurvayLanguage>();
            SurvayQuestion = new HashSet<SurvayQuestion>();
        }

        public int SurvayId { get; set; }
        public bool Ispublished { get; set; }
        public bool Isdefault { get; set; }
        public DateTime SurvayDate { get; set; }
        public int SurvayOrder { get; set; }

        public ICollection<SurvayLanguage> SurvayLanguage { get; set; }
        public ICollection<SurvayQuestion> SurvayQuestion { get; set; }
    }
}
