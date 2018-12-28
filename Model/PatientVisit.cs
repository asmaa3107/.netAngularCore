using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class PatientVisit
    {
        public int PatientVisitId { get; set; }
        public DateTime VisitDate { get; set; }
        public string Diagnoses { get; set; }
    }
}
