using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class GroupUser
    {
        public GroupUser()
        {
            this.GroupGoals = new List<GroupGoal>();
        }

        public int GroupUserId { get; set; }
        public int GroupId { get; set; }
        public string UserId { get; set; }
        public bool Admin { get; set; }
        public System.DateTime AddedDate { get; set; }
        public virtual ICollection<GroupGoal> GroupGoals { get; set; }
    }
}
