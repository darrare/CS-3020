using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndInterfaces_Demo
{
    class Audio : IMedia
    {

        public Audio()
        {

        }

        public string Path { get; set; }
        public FileInfo File { get; set; }
        public FileType FileType { get; set; }
        public MediaType MediaType { get; set; }
        public DateTime DateAdded { get; set; }

        public void PlaySoundFile()
        {

        }
    }
}
