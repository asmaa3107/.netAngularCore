using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class JobApplicant
    {
        public int ApplicantId { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantInfo { get; set; }
        public string ApplicantFormPath { get; set; }
        public int FkJobId { get; set; }

        public Job FkJob { get; set; }
    }
}
