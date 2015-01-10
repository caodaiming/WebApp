using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class SupportInvitation
    {
        public int SupportInvitationId { get; set; }
        public string FromUserId { get; set; }
        public int GoalId { get; set; }
        public string ToUserId { get; set; }
        public System.DateTime SentDate { get; set; }
        public bool Accepted { get; set; }
        public virtual Goal Goal { get; set; }
    }
}
