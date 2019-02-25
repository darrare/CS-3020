using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExampleProject
{
    enum FileType { WAV, MP3, MP4, AVI, MOV, PNG, JPG }
    enum MediaType { Audio, Video, Image }
    class Media
    {
        public string Path { get; set; }
        public FileInfo File { get; set; }
        public FileType FileType { get; set; }
        public MediaType MediaType { get; set; }
        public DateTime DateLastModified { get; set; }

        public Media(string path, FileInfo file, FileType fileType, MediaType mediaType)
        {
            Path = path;
            File = file;
            FileType = fileType;
            MediaType = mediaType;
        }
    }
}
