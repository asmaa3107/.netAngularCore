using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class DoctorDepartMent
    {
        public int DoPartId { get; set; }
        public int FkDoctorId { get; set; }
        public int FkDeptId { get; set; }
    }
}
