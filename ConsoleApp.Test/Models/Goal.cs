using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class Goal
    {
        public Goal()
        {
            this.SupportInvitations = new List<SupportInvitation>();
            this.Supports = new List<Support>();
            this.Updates = new List<Update>();
        }

        public int GoalId { get; set; }
        public string GoalName { get; set; }
        public string Desc { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<double> Target { get; set; }
        public bool GoalType { get; set; }
        public Nullable<int> MetricId { get; set; }
        public int GoalStatusId { get; set; }
        public string UserId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual GoalStatu GoalStatu { get; set; }
        public virtual Metric Metric { get; set; }
        public virtual ICollection<SupportInvitation> SupportInvitations { get; set; }
        public virtual ICollection<Support> Supports { get; set; }
        public virtual ICollection<Update> Updates { get; set; }
    }
}
