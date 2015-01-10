using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApp.Model.Models;

namespace WebApp.Web.Core.Extensions
{
    /// <summary>
    /// 下来列表选择扩展
    /// </summary>
    public static class SelectListExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItem(
            this IEnumerable<Category> category, int selectedId)
        {
            return category.OrderBy(p => p.CategoryName)
                             .Select(p =>
                                 new SelectListItem
                                 {
                                     Selected = (p.Id == selectedId),
                                     Text = p.CategoryName,
                                     Value = p.Id.ToString()
                                 });
        }
    }
}
