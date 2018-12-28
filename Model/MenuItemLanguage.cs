using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class MenuItemLanguage
    {
        public int MenuItemLanguageId { get; set; }
        public string MenuItemName { get; set; }
        public int FkMenuItemId { get; set; }
        public string LanguageName { get; set; }

        public MenuItem FkMenuItem { get; set; }
    }
}
