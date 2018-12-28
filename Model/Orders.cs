using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int FkCompanyId { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsDevlivered { get; set; }
        public Guid FkUserId { get; set; }

        public TCompanies FkCompany { get; set; }
        public AspnetUsers FkUser { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
