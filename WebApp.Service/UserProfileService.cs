using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Data.Infrastructure;
using WebApp.Data.Repository;
using WebApp.Model.Models;

namespace WebApp.Service
{

    public interface IUserProfileService
    {
        UserProfile GetProfile(int id);

        UserProfile GetUser(string userId);

        IEnumerable<UserProfile> GetAllUserProfile();

        UserProfile GetUserByEmail(string email);

        void UpdateUserProfile(UserProfile user);

        void SaveUserProfile();
    }

    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository userProfileRepository;

        private readonly IUnitOfWork unitOfWork;

        public UserProfileService(IUserProfileRepository userProfileRepository, IUnitOfWork unitOfWork)
        {
            this.userProfileRepository = userProfileRepository;
            this.unitOfWork = unitOfWork;
        }

        public UserProfile GetProfile(int id)
        {
            var userprofile = userProfileRepository.Get(u => u.UserProfileId == id);

            return userprofile;
        }

        public UserProfile GetUser(string userId)
        {
            return userProfileRepository.Get(u => u.UserId == userId);
        }

        public UserProfile GetUserByEmail(string email)
        {
            return userProfileRepository.Get(u => u.Email == email);
        }

        public void UpdateUserProfile(UserProfile user)
        {
            userProfileRepository.Update(user);
            SaveUserProfile();
        }

        public void SaveUserProfile()
        {
            this.unitOfWork.Commit();
        }


        public IEnumerable<UserProfile> GetAllUserProfile()
        {
            return userProfileRepository.GetAll();
        }
    }
}
