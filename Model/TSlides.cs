using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class TSlides
    {
        public int Id { get; set; }
        public int? FkProid { get; set; }
        public int? Value { get; set; }
        public int? AddValue { get; set; }
        public int? TotalValue { get; set; }
    }
}
