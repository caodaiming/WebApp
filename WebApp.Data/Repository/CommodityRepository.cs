using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Models;
using WebApp.Data.Infrastructure;
namespace WebApp.Data.Repository
{
    public interface ICommoidityRepository : IRepository<Commodity>
    {

    }
    public class CommodityRepository : RepositoryBase<Commodity>, ICommoidityRepository
    {
        public CommodityRepository(IDatatbaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
}
