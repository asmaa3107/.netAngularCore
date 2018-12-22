using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class AspnetUsers
    {
        public AspnetUsers()
        {
            Article = new HashSet<Article>();
            AspnetPersonalizationPerUser = new HashSet<AspnetPersonalizationPerUser>();
            AspnetUsersInRoles = new HashSet<AspnetUsersInRoles>();
            Comment = new HashSet<Comment>();
            FeedBack = new HashSet<FeedBack>();
            Orders = new HashSet<Orders>();
        }

        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AspnetApplications Application { get; set; }
        public AspnetMembership AspnetMembership { get; set; }
        public AspnetProfile AspnetProfile { get; set; }
        public ICollection<Article> Article { get; set; }
        public ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public ICollection<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<FeedBack> FeedBack { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
