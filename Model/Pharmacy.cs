using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Pharmacy
    {
        public int PharmId { get; set; }
        public string PharmName { get; set; }
        public Guid? FkUserId { get; set; }
        public int? FkRegion { get; set; }
        public string PharmAdress { get; set; }
        public string PharmPhone { get; set; }
        public string PharmMobile1 { get; set; }
        public string PharmMobile2 { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? NewExpierdDate { get; set; }
    }
}
