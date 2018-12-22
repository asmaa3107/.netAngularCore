using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Setting
    {
        public Setting()
        {
            Meeenu = new HashSet<Meeenu>();
            PhotoGallery = new HashSet<PhotoGallery>();
        }

        public int SettingId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public int FkSettingTypeId { get; set; }

        public SettingType FkSettingType { get; set; }
        public ICollection<Meeenu> Meeenu { get; set; }
        public ICollection<PhotoGallery> PhotoGallery { get; set; }
    }
}
