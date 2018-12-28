using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class FeedBack
    {
        public int FeedBackId { get; set; }
        public string FeedbackTitle { get; set; }
        public string FeedBackEmail { get; set; }
        public Guid? FkUserId { get; set; }
        public string FeedBackContent { get; set; }

        public AspnetUsers FkUser { get; set; }
    }
}
