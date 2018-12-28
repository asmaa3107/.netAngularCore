using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class EventLanguage
    {
        public int EventLanguageId { get; set; }
        public int FkEventId { get; set; }
        public string Title { get; set; }
        public string EventContent { get; set; }
        public string LangName { get; set; }

        public Event FkEvent { get; set; }
    }
}
