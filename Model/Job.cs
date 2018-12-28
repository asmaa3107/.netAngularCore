using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Job
    {
        public Job()
        {
            JobApplicant = new HashSet<JobApplicant>();
            JobLanguage = new HashSet<JobLanguage>();
        }

        public int JobId { get; set; }
        public bool? Ispublished { get; set; }
        public string JobDate { get; set; }
        public string ApplicationFormPath { get; set; }

        public ICollection<JobApplicant> JobApplicant { get; set; }
        public ICollection<JobLanguage> JobLanguage { get; set; }
    }
}
