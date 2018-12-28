using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public Guid? FkUserId { get; set; }
        public string SubjectType { get; set; }
        public int SubjectId { get; set; }
        public int? NoOfComments { get; set; }

        public AspnetUsers FkUser { get; set; }
    }
}
