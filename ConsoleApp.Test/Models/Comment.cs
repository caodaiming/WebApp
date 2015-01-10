using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public int UpdateId { get; set; }
        public System.DateTime CommentDate { get; set; }
        public virtual Update Update { get; set; }
    }
}
