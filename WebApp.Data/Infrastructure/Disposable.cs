using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Data.Infrastructure
{
    /// <summary>
    /// 内存管理和垃圾回收
    /// </summary>
    public class Disposable : IDisposable
    {
        private bool isDisposed;
        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();  //释放托管对象
            }

            isDisposed = true;
        }

        protected virtual void DisposeCore()
        { 
        }
    }
}
