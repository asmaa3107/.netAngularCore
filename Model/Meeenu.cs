using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Meeenu
    {
        public Meeenu()
        {
            MenuItem = new HashSet<MenuItem>();
            MenuLanguage = new HashSet<MenuLanguage>();
        }

        public int MenuId { get; set; }
        public bool IsPublished { get; set; }
        public DateTime MenuDate { get; set; }
        public int? MenuOrder { get; set; }
        public int? MenuSettingDisplayId { get; set; }

        public Setting MenuSettingDisplay { get; set; }
        public ICollection<MenuItem> MenuItem { get; set; }
        public ICollection<MenuLanguage> MenuLanguage { get; set; }
    }
}
