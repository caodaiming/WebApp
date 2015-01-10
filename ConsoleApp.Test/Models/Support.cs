using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class Support
    {
        public int SupportId { get; set; }
        public int GoalId { get; set; }
        public string UserId { get; set; }
        public System.DateTime SupportedDate { get; set; }
        public virtual Goal Goal { get; set; }
    }
}
