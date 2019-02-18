using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndInterfaces_Demo
{
    public class MyResource : IDisposable
    {
        private IntPtr handle;
        private Component component = new Component();
        private bool disposed = false;

        public MyResource(IntPtr handle)
        {
            this.handle = handle;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    component.Dispose();

                CloseHandle(handle);
                handle = IntPtr.Zero;

                disposed = true;
            }
        }

        [System.Runtime.InteropServices.DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle);

        ~MyResource()
        {
            Dispose(false);
        }
    }
}


