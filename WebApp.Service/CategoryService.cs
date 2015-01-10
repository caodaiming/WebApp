using PagedList;
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
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategory();
        IPagedList<Category> GetCategories(Page page);
    }
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }


        public IEnumerable<Category> GetCategory()
        {
            return categoryRepository.GetAll();
        }


        public IPagedList<Category> GetCategories(Page page)
        {
            return categoryRepository.GetPage(page, x => true, order => order.CategoryName);
        }
    }
}
