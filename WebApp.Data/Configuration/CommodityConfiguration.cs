using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Models;

namespace WebApp.Data.Configuration
{
    public class CommodityConfiguration : EntityTypeConfiguration<Commodity>
    {
        public CommodityConfiguration()
        {
            Property(m => m.CommodityInfo).HasMaxLength(100);
            Property(m => m.CommodityName).HasMaxLength(100);
        }
    }
}
