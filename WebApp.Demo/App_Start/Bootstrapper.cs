using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Autofac.Integration.Mvc;
using System.Reflection;
using WebApp.Data.Infrastructure;
using WebApp.Data.Repository;
using WebApp.Service;
using System.Web.Mvc;

namespace WebApp.Demo
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            Mappings.AutoMapperConfiguration.Configure();
            SetAutofacContainer();
        }

        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerHttpRequest();
            builder.RegisterType<DatabaseFactory>().As<IDatatbaseFactory>().InstancePerHttpRequest();
            builder.RegisterAssemblyTypes(typeof(CategoryRepository).Assembly)
                .Where(t=>t.Name.Contains("Repository"))
                .AsImplementedInterfaces().InstancePerHttpRequest();
            builder.RegisterAssemblyTypes(typeof(CategoryService).Assembly)
                .Where(t=>t.Name.Contains("Service"))
                .AsImplementedInterfaces().InstancePerHttpRequest();


            builder.RegisterFilterProvider();
            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}