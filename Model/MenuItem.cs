using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            InverseFkMenuItemParent = new HashSet<MenuItem>();
            MenuItemLanguage = new HashSet<MenuItemLanguage>();
        }

        public int MenuItemId { get; set; }
        public bool IsPublished { get; set; }
        public int? MenuItemOrder { get; set; }
        public int? FkMenuItemParentId { get; set; }
        public int FkMenuId { get; set; }
        public DateTime MenuItemDate { get; set; }
        public string MenuItemUrl { get; set; }
        public int? FkArticleId { get; set; }

        public Article FkArticle { get; set; }
        public Meeenu FkMenu { get; set; }
        public MenuItem FkMenuItemParent { get; set; }
        public ICollection<MenuItem> InverseFkMenuItemParent { get; set; }
        public ICollection<MenuItemLanguage> MenuItemLanguage { get; set; }
    }
}
