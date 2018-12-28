using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Contacts { get; set; }
        public string PatientHistoryDisease { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Adress { get; set; }
        public string Message { get; set; }
        public DateTime? RserveDate { get; set; }
    }
}
