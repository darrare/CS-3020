using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaManagement
{
    abstract class MediaCollectionAbstract
    {
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleWindow", SetLastError = true)]
        protected  static extern IntPtr GetConsoleHandle();

        public abstract bool TouchFile(int index);
        public abstract bool RemoveFile(int index);
        public abstract bool UseFile(int index);
        public abstract bool PrintLibrary();
        public abstract void SortByName();
        public abstract void SortByExtension();
        public abstract void SortByDateLastAccessed();
    }
}
