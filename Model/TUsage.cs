using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class TUsage
    {
        public int UsageId { get; set; }
        public string UsageTitle { get; set; }
        public string UsageDesc { get; set; }
        public string UsageImage { get; set; }
        public int? FkParentIt { get; set; }
    }
}
