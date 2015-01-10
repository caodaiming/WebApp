using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class RegistrationToken
    {
        public int RegistrationTokenId { get; set; }
        public System.Guid Token { get; set; }
        public string Role { get; set; }
    }
}
