using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Data.Infrastructure;
using WebApp.Model;
using WebApp.Model.Models;

namespace WebApp.Data.Repository
{
    public class UserProfileRepository : RepositoryBase<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(IDatatbaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }

    }

    public interface IUserProfileRepository : IRepository<UserProfile>
    {

    }
}
