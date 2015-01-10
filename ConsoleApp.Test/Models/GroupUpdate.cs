using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class GroupUpdate
    {
        public GroupUpdate()
        {
            this.GroupComments = new List<GroupComment>();
            this.GroupUpdateSupports = new List<GroupUpdateSupport>();
        }

        public int GroupUpdateId { get; set; }
        public string Updatemsg { get; set; }
        public Nullable<double> status { get; set; }
        public int GroupGoalId { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public virtual ICollection<GroupComment> GroupComments { get; set; }
        public virtual GroupGoal GroupGoal { get; set; }
        public virtual ICollection<GroupUpdateSupport> GroupUpdateSupports { get; set; }
    }
}
