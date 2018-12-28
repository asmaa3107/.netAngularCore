using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class DoctorAvailabeTime
    {
        public int AvaiableTimeId { get; set; }
        public DateTime Day { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public int FkDoctorId { get; set; }
    }
}
