using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class Update
    {
        public Update()
        {
            this.Comments = new List<Comment>();
            this.UpdateSupports = new List<UpdateSupport>();
        }

        public int UpdateId { get; set; }
        public string Updatemsg { get; set; }
        public Nullable<double> status { get; set; }
        public int GoalId { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Goal Goal { get; set; }
        public virtual ICollection<UpdateSupport> UpdateSupports { get; set; }
    }
}
