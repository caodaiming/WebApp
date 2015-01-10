using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class SecurityToken
    {
        public int SecurityTokenId { get; set; }
        public System.Guid Token { get; set; }
        public int ActualID { get; set; }
    }
}
