using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Model.Models
{
    public class Commodity
    {
        [Key]
        public int Id { get; set; }

        public string CommodityName { get; set; }

        public virtual Category Category { get; set; }

        public decimal? CommodityPrice { get; set; }

        public string CommodityInfo { get; set; }
    }
}
