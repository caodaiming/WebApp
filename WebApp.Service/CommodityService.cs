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
    public interface ICommodityService
    {
        IEnumerable<Commodity> GetAllCommodity();
    }
    public class CommodityService : ICommodityService
    {
        private readonly ICommoidityRepository commodityRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;
        public CommodityService(ICommoidityRepository commodityRepository,ICategoryRepository categoryRepository,IUnitOfWork unitOfWork)
        {
            this.categoryRepository = categoryRepository;
            this.commodityRepository = commodityRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Commodity> GetAllCommodity()
        {
            return commodityRepository.GetAll();
          //  return commodityRepository.GetMany(u=>u.Category ==  categoryRepository.GetById(u.Category.Id));

        }
    }
}
