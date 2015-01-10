using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebApp.Model.Models;
using System.Data.Entity.ModelConfiguration;
namespace WebApp.Data.Configuration
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {

            Property(m => m.Id).IsRequired();
            Property(m => m.CategoryName).HasMaxLength(100);
            Property(m => m.CategoryInfo).HasMaxLength(100);
        }
    }
}
