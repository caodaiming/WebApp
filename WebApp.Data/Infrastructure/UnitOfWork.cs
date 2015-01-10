using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatatbaseFactory databaseFactory;
        private WebAppEntities dataContext;


        public UnitOfWork(IDatatbaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected WebAppEntities DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }
        public void Commit()
        {
            DataContext.Commit();
        }
    }
}
