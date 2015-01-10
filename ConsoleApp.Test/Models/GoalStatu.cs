using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class GoalStatu
    {
        public GoalStatu()
        {
            this.Goals = new List<Goal>();
            this.GroupGoals = new List<GroupGoal>();
        }

        public int GoalStatusId { get; set; }
        public string GoalStatusType { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<GroupGoal> GroupGoals { get; set; }
    }
}
