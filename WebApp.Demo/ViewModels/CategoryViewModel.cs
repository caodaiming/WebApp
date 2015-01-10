using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Demo.ViewModels
{
    public class CategoryViewModel
    {
        [Display(Name="分类编号")]
        public int CategoryId { get; set; }

        [Display(Name="分类名称")]
        public string CategoryName { get; set; }
        [Display(Name="备注信息")]
        public string CategoryInfo { get; set; }

    }
}