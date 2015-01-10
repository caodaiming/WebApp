using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class Group
    {
        public Group()
        {
            this.Foci = new List<Focus>();
            this.GroupGoals = new List<GroupGoal>();
            this.GroupInvitations = new List<GroupInvitation>();
            this.GroupRequests = new List<GroupRequest>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public virtual ICollection<Focus> Foci { get; set; }
        public virtual ICollection<GroupGoal> GroupGoals { get; set; }
        public virtual ICollection<GroupInvitation> GroupInvitations { get; set; }
        public virtual ICollection<GroupRequest> GroupRequests { get; set; }
    }
}
