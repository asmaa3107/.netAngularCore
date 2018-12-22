using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class TProducts
    {
        public TProducts()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int ProId { get; set; }
        public string ProName { get; set; }
        public int FkCompId { get; set; }
        public int FkUsageId { get; set; }
        public string ProDesc { get; set; }
        public string ProIngredients { get; set; }
        public bool? IsPublished { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? AskedForDelete { get; set; }
        public DateTime? CreationDate { get; set; }
        public string SmallThumbImg { get; set; }
        public string LargResizedImg { get; set; }
        public double? AvrageRating { get; set; }
        public int? Quantity { get; set; }
        public double? PublicPrice { get; set; }
        public double? PharmPrice { get; set; }
        public double? DiscountRate { get; set; }
        public string ProductCode { get; set; }

        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
