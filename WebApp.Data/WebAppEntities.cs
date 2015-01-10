using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Data.Configuration;
using WebApp.Model.Models;

namespace WebApp.Data
{
    public class WebAppEntities : DbContext
    {
        public WebAppEntities()
            : base("WebAppEntities")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<Category> Categorys { get; set; }

        public virtual DbSet<Commodity> Commoditys { get; set; }


        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();


            modelBuilder.Configurations.Add(new UserProfileConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());

            modelBuilder.Configurations.Add(new CommodityConfiguration());
        }
    }
}
