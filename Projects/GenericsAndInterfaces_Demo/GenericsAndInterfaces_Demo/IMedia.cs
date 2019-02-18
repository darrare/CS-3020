using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GenericsAndInterfaces_Demo
{
    enum FileType { WAV, MP3, MP4, AVI, MOV, PNG, JPG }
    enum MediaType { Audio, Video, Image }
    interface IMedia
    {
        string Path { get; set; }
        FileInfo File { get; set; }
        FileType FileType { get; set; }
        MediaType MediaType { get; set; }
        DateTime DateAdded { get; set; }
    }
}
