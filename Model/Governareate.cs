using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Governareate
    {
        public Governareate()
        {
            Region = new HashSet<Region>();
        }

        public int GovernareateId { get; set; }
        public string GovernareteName { get; set; }

        public ICollection<Region> Region { get; set; }
    }
}
