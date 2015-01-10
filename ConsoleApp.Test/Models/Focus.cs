using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class Focus
    {
        public Focus()
        {
            this.GroupGoals = new List<GroupGoal>();
        }

        public int FocusId { get; set; }
        public string FocusName { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<GroupGoal> GroupGoals { get; set; }
    }
}
