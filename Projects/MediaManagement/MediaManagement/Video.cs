using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediaManagement
{
    class Video : IMedia
    {
        public string Path { get; set; }
        public FileInfo File { get; set; }
        public FileType FileType { get; set; }
        public MediaType MediaType { get; set; }
        public DateTime DateAdded { get; set; }

        public Video(string path, FileInfo file, FileType fileType, DateTime dateAdded)
        {
            Path = path;
            File = file;
            FileType = fileType;
            DateAdded = dateAdded;
            MediaType = MediaType.Video;
        }
    }
}
