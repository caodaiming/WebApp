using System;
using System.Collections.Generic;

namespace ConsoleApp.Test.Models
{
    public partial class UserProfile
    {
        public int UserProfileId { get; set; }
        public System.DateTime DateEdited { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Nullable<double> ZipCode { get; set; }
        public Nullable<double> ContactNo { get; set; }
        public string UserId { get; set; }
    }
}
