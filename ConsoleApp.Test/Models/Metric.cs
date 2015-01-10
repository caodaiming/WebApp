using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class Metric
    {
        public Metric()
        {
            this.Goals = new List<Goal>();
            this.GroupGoals = new List<GroupGoal>();
        }

        public int MetricId { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<GroupGoal> GroupGoals { get; set; }
    }
}
