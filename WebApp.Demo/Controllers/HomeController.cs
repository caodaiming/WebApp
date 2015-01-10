using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Data;
using WebApp.Demo.ViewModels;
using WebApp.Model.Models;
using WebApp.Service;

namespace WebApp.Demo.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ICategoryService categoryService;
        private readonly ICommodityService commodityService;
        
        public HomeController()
        {

        }

        public HomeController(ICategoryService categoryService, ICommodityService commodityService)
        {
            this.commodityService = commodityService;
            this.categoryService = categoryService;
        }

        // GET: Home
        public ActionResult Index()
        {
           
            var lst = categoryService.GetCategory();

            var categorys = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(lst);

            return View(categorys);
        }
    }
}