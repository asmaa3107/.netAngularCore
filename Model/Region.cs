using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public int FkGovernerateId { get; set; }

        public Governareate FkGovernerate { get; set; }
    }
}
