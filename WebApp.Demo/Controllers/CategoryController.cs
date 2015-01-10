using AutoMapper;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Data.Infrastructure;
using WebApp.Demo.ViewModels;
using WebApp.Model.Models;
using WebApp.Service;

namespace WebApp.Demo.Controllers
{
    [Authorize]
    public class CategoryController : BaseController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        // GET: Category

        [AllowAnonymous]
        public ActionResult CategoryList(int page = 1)
        {

            var categories = categoryService.GetCategories(new Page(page, 10));

            var categoryViewModel = Mapper.Map<IPagedList<Category>, IPagedList<CategoriesItemViewModel>>(categories);

            var categoryPageViewModel = new CategoryPageViewModel {  CategoryList = categoryViewModel};

            //if (Request.IsAjaxRequest())
            //{
                return View("CategoryList", categoryPageViewModel);
            //}
            //return null;
        }


    }
}