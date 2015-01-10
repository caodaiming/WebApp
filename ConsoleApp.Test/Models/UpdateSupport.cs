using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class UpdateSupport
    {
        public int UpdateSupportId { get; set; }
        public int UpdateId { get; set; }
        public string UserId { get; set; }
        public System.DateTime UpdateSupportedDate { get; set; }
        public virtual Update Update { get; set; }
    }
}
