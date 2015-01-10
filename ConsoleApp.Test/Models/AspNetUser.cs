using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            this.AspNetUserClaims = new List<AspNetUserClaim>();
            this.AspNetUserLogins = new List<AspNetUserLogin>();
            this.FollowUsers = new List<FollowUser>();
            this.FollowUsers1 = new List<FollowUser>();
            this.FollowUsers2 = new List<FollowUser>();
            this.FollowUsers3 = new List<FollowUser>();
            this.Goals = new List<Goal>();
            this.GroupRequests = new List<GroupRequest>();
            this.AspNetRoles = new List<AspNetRole>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicUrl { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public Nullable<bool> Activated { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string Discriminator { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<FollowUser> FollowUsers { get; set; }
        public virtual ICollection<FollowUser> FollowUsers1 { get; set; }
        public virtual ICollection<FollowUser> FollowUsers2 { get; set; }
        public virtual ICollection<FollowUser> FollowUsers3 { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<GroupRequest> GroupRequests { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}
