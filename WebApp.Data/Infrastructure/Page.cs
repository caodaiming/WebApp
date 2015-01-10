using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Data.Infrastructure
{
    public class Page
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public Page()
        {
            PageNumber = 1;
            PageSize = 20;
        }

        public Page(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public int Skip
        {
            get { return (PageNumber - 1) * PageSize; }
        }
    }
    /// <summary>
    /// Extend IQueryable to simplify access to skip and take methods
    /// </summary>
    ///<typeparm name="T"></typeparm>
    ///<param name="queryable"></param>
    ///<param name="page"></param>
    ///<return>IQueryable with skip and take having been performed</return>
    public static class PageingExtensions
    {
        public static IQueryable<T> GetPage<T>(this IQueryable<T> queryable, Page page)
        {
            return queryable.Skip(page.Skip).Take(page.PageSize);
        }
    }
}
