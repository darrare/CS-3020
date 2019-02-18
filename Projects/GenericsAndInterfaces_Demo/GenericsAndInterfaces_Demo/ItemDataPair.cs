using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndInterfaces_Demo
{
    class DataInterfacePair<D, I> where D : struct where I : class
    {
        public D Data { get; }

        public I Interface { get; }

        public DataInterfacePair(D data, I inter)
        {
            Data = data;
            Interface = inter;
        }
    }
}

