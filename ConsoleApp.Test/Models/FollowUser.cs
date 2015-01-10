using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class FollowUser
    {
        public int FollowUserId { get; set; }
        public string ToUserId { get; set; }
        public string FromUserId { get; set; }
        public bool Accepted { get; set; }
        public System.DateTime AddedDate { get; set; }
        public string ApplicationUser_Id { get; set; }
        public string ApplicationUser_Id1 { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual AspNetUser AspNetUser2 { get; set; }
        public virtual AspNetUser AspNetUser3 { get; set; }
    }
}
