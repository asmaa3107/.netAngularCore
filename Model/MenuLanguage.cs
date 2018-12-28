using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class MenuLanguage
    {
        public int MenuLanguageId { get; set; }
        public string MenuName { get; set; }
        public string LanguageName { get; set; }
        public int FkMenuId { get; set; }

        public Meeenu FkMenu { get; set; }
    }
}
