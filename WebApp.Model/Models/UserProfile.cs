using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Model.Models
{
    public class UserProfile
    {
        public UserProfile()
        {
            DataEdited = DateTime.Now;
        }

        [Key]
        public int UserProfileId { get; set; }

        public DateTime DataEdited { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateBirth { get; set; }

        public bool? Gender { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
        
        public string State { get; set; }

        public string  Country { get; set; }

        public double? ZipCode { get; set; }

        public double? ContactNo { get; set; }

        public string UserId { get; set; }
    }
}
