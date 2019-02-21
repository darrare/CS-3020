using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediaManagement
{
    class Audio : IMedia
    {
        public string Path { get; set; }
        public FileInfo File { get; set; }
        public FileType FileType { get; set; }
        public MediaType MediaType { get; set; }
        public DateTime DateLastModified { get; set; }

        public Audio(string path, FileInfo file, FileType fileType, DateTime dateAdded)
        {
            Path = path;
            File = file;
            FileType = fileType;
            DateLastModified = dateAdded;
            MediaType = MediaType.Audio;
        }
    }
}
