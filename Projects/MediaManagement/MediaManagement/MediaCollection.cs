using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManagement
{
    class MediaCollection<T> where T : IMedia
    {
        public List<T> Media { get; set; } = new List<T>();

        public void Print()
        {

        }

        public void Touch()
        {

        }
        public void Remove()
        {

        }
    }
}
