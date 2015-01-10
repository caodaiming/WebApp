using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class GroupGoal
    {
        public GroupGoal()
        {
            this.GroupUpdates = new List<GroupUpdate>();
        }

        public int GroupGoalId { get; set; }
        public string GoalName { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<double> Target { get; set; }
        public Nullable<int> MetricId { get; set; }
        public Nullable<int> FocusId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int GoalStatusId { get; set; }
        public int GroupUserId { get; set; }
        public Nullable<int> AssignedGroupUserId { get; set; }
        public string AssignedTo { get; set; }
        public int GroupId { get; set; }
        public virtual Focus Focus { get; set; }
        public virtual GoalStatu GoalStatu { get; set; }
        public virtual Group Group { get; set; }
        public virtual GroupUser GroupUser { get; set; }
        public virtual Metric Metric { get; set; }
        public virtual ICollection<GroupUpdate> GroupUpdates { get; set; }
    }
}
