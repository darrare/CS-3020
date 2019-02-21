using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediaManagement
{
    enum FileType { WAV, MP3, MP4, AVI, PNG, JPG }
    enum MediaType { Audio, Video, Image, All }
    interface IMedia
    {
        string Path { get; set; }
        FileInfo File { get; set; }
        FileType FileType { get; set; }
        MediaType MediaType { get; set; }
        DateTime DateLastModified { get; set; }
    }
}
