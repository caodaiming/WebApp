using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Demo.ViewModels
{
    public class UserProfileViewModel
    {
        [Display(Name="用户编号")]
        public string  UserId { get; set; }
        [Display(Name = "电子邮件")]
        public string  Email { get; set; }
        [Display(Name = "姓")]
        public string  FirstName { get; set; }
        [Display(Name = "名")]
        public string LastName { get; set; }

        public string ProfilePicUrl { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? Gender { get; set; }

        public string Address { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string City { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string State { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Country { get; set; }

        public double? ZipCode { get; set; }

        [DataType(DataType.PhoneNumber)]
        public double? ContactNo { get; set; }

        public bool RequestSent { get; set; }

        public bool Following { get; set; }

        public string UserName { get; set; }


    }
}