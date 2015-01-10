using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApp.Web.Core.Models;

namespace WebApp.Web.Core.ActionFilters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class LayoutAttribute : ActionFilterAttribute
    {

        public LayoutAttribute()
        {
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
           // var user = SessionHelper.GetSession("CurrUser");

            (filterContext.Result as ViewResult).ViewBag.LoginName = "曹代明";

            //左侧菜单
            ((ViewResult)filterContext.Result).ViewBag.SidebarMenuModel = InitSidebarMenu();

            //面包屑
            ((ViewResult)filterContext.Result).ViewBag.BreadCrumbModel = InitBreadCrumb(filterContext);
            base.OnResultExecuting(filterContext);
        }


        private string InitBreadCrumb(ResultExecutingContext filterContext)
        {
            var area = filterContext.RouteData.DataTokens.ContainsKey("area") ? filterContext.RouteData.DataTokens["area"].ToString().ToLower() : string.Empty;
            var controller = filterContext.RouteData.Values["controller"].ToString().ToLower();
            var action = filterContext.RouteData.Values["action"].ToString().ToLower();

            string linkUrl = string.Format("{0}/{1}/{2}", area, controller, action);

            return linkUrl;

        }
        private List<SidebarMenuModel> InitSidebarMenu()
        {
            List<Models.SidebarMenuModel> lst = new List<Models.SidebarMenuModel>();
            List<Models.SidebarMenuModel> child_1 = new List<Models.SidebarMenuModel>();
            List<Models.SidebarMenuModel> child_2 = new List<Models.SidebarMenuModel>();



            child_1.Add(new Models.SidebarMenuModel
            {
                Name = "产品管理",
                Action = "Index",
                Controller = "Product"
            });
            child_1.Add(new Models.SidebarMenuModel
            {
                Name = "分类管理",
                Action = "CategoryList",
                Controller = "Category"
            });

            child_2.Add(new Models.SidebarMenuModel
            {
                Name = "用户管理",
                Action = "Index",
                Controller = "User"
            });
            child_2.Add(new Models.SidebarMenuModel
            {
                Name = "个人设置",
                Action = "EditInfo",
                Controller = "User"
            });

            lst.Add(new Models.SidebarMenuModel
            {
                Name = "产品",
                Icon = "icon-list",
                ChildMenuList = child_1
            });

          

            return lst;
        }
    }
}