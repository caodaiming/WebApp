using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class GroupUpdateSupport
    {
        public int GroupUpdateSupportId { get; set; }
        public int GroupUpdateId { get; set; }
        public int GroupUserId { get; set; }
        public System.DateTime UpdateSupportedDate { get; set; }
        public virtual GroupUpdate GroupUpdate { get; set; }
    }
}
