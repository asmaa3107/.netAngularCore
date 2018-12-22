using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class SettingType
    {
        public SettingType()
        {
            Setting = new HashSet<Setting>();
        }

        public int SettingTypeId { get; set; }
        public string SettingTypeName { get; set; }

        public ICollection<Setting> Setting { get; set; }
    }
}
