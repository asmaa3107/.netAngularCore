﻿using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class AspnetPersonalizationAllUsers
    {
        public Guid PathId { get; set; }
        public byte[] PageSettings { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public AspnetPaths Path { get; set; }
    }
}
