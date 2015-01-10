using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatatbaseFactory
    {
        private WebAppEntities dataContext;
        public WebAppEntities Get()
        {
            return dataContext ?? (dataContext = new WebAppEntities());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
            {
                dataContext.Dispose();
            }
        }

    }
}
