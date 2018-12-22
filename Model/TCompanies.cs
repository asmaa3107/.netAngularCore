using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class TCompanies
    {
        public TCompanies()
        {
            Orders = new HashSet<Orders>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDesc { get; set; }
        public string ComOriginalPhoto { get; set; }
        public string ComThumbPhoto { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid? FkUserid { get; set; }
        public string Adress { get; set; }
        public string Phons { get; set; }
        public string PayWays { get; set; }
        public string ReturnsPolicy { get; set; }
        public DateTime? LastActivationDate { get; set; }
        public int? FkGovid { get; set; }
        public string PreferedLanguage { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
