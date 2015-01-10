using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Demo.ViewModels;
using WebApp.Model.Models;
using WebApp.Service;

namespace WebApp.Demo.Controllers
{
    public class UserProfileController : BaseController
    {
        private readonly IUserProfileService userProfileService;

        public UserProfileController(IUserProfileService userProfileService)
        {
            this.userProfileService = userProfileService;
        }

        // GET: UserProfile
        public ActionResult Index()
        {
            var userProfiles = Mapper.Map<IEnumerable<UserProfile>, IEnumerable<UserProfileViewModel>>(userProfileService.GetAllUserProfile());

            return View(userProfiles);
        }
    }
}