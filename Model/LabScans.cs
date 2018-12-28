using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class LabScans
    {
        public int LabScanId { get; set; }
        public string LsType { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Attachment { get; set; }
        public int FkPatientVisit { get; set; }
    }
}
