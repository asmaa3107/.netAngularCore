using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class OrderItems
    {
        public int OrderItemId { get; set; }
        public int FkProductId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public int FkOrderId { get; set; }

        public Orders FkOrder { get; set; }
        public TProducts FkProduct { get; set; }
    }
}
