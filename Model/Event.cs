using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Event
    {
        public Event()
        {
            EventLanguage = new HashSet<EventLanguage>();
        }

        public int EventId { get; set; }
        public string EventDate { get; set; }
        public bool IsPublished { get; set; }
        public int? EventOrder { get; set; }
        public string ImagePath { get; set; }

        public ICollection<EventLanguage> EventLanguage { get; set; }
    }
}
