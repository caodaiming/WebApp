using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebApp.Model.Models;
namespace WebApp.Data
{
    public class WebAppSampleData : DropCreateDatabaseIfModelChanges<WebAppEntities>
    {

        protected override void Seed(WebAppEntities context)
        {


            //init database default data
            new List<UserProfile>{
                new UserProfile{ UserId = Guid.NewGuid().ToString(),UserProfileId=2,Email="gmawaje@sou.com"},
                new UserProfile{ UserId = Guid.NewGuid().ToString(),UserProfileId=2,Email="gmawaje@sou.com"},
                new UserProfile{ UserId = Guid.NewGuid().ToString(),UserProfileId=2,Email="gmawaje@sou.com"},
                new UserProfile{ UserId = Guid.NewGuid().ToString(),UserProfileId=2,Email="gmawaje@sou.com"},
                new UserProfile{ UserId = Guid.NewGuid().ToString(),UserProfileId=2,Email="gmawaje@sou.com"}
            }.ForEach(m => context.UserProfiles.Add(m));


            new List<Category> { 
                new Category{ CategoryName="小米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="苹果手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="三星手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="红米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="华为手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="中兴手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="小米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="苹果手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="三星手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="红米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="华为手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="中兴手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="小米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="苹果手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="三星手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="红米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="华为手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="中兴手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="小米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="苹果手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="三星手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="红米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="华为手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="中兴手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="小米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="苹果手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="三星手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="红米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="华为手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="中兴手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="小米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="苹果手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="三星手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="红米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="华为手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="中兴手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="小米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="苹果手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="三星手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="红米手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="华为手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="中兴手机", CategoryInfo="各类型手机"},
                new Category{ CategoryName="酷派手机", CategoryInfo="各类型手机"}
            }.ForEach(m => context.Categorys.Add(m));

          
            context.Commit();
        }
    }
}
