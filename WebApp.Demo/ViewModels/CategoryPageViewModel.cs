using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Demo.ViewModels
{
    public class CategoryPageViewModel
    {
        public IPagedList<CategoriesItemViewModel> CategoryList { get; set; }
    }
}