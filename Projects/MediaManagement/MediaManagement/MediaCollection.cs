using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using WMPLib;
using System.Drawing;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MediaManagement
{

    class MediaCollection<T> : MediaCollectionAbstract where T : IMedia
    {
        public List<T> Media { get; set; } = new List<T>();

        public override bool TouchFile(int index)
        {
            if (Media.Count >= index)
            {
                Media[index - 1].DateLastModified = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool RemoveFile(int index)
        {
            if (Media.Count >= index)
            {
                Media.RemoveAt(index - 1);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool UseFile(int index)
        {
            T file;
            if (Media.Count >= index)
            {
                file = Media[index - 1];
                if (file.MediaType == MediaType.Audio)
                {
                    WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
                    myplayer.URL = file.File.FullName;
                    myplayer.controls.play();
                }
                else if (file.MediaType == MediaType.Image)
                {
                    var handler = GetConsoleHandle();

                    using (var graphics = Graphics.FromHwnd(handler))
                    using (var image = System.Drawing.Image.FromFile(file.File.FullName))
                        graphics.DrawImage(image, 50, 50, 250, 200);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool PrintLibrary()
        {
            if (Media.Count == 0)
            {
                Console.WriteLine("Library is empty");
                return false;
            }
            int indexWidth = Media.Count.ToString().Length;
            int fileNameWidth = Media.Aggregate("", (longest, next) => next.File.Name.Length > longest.Length ? next.File.Name : longest).Length;
            int fileExtensionWidth = 3;
            int dateLastAccessedWidth = Media.Aggregate("", (longest, next) => next.DateLastModified.ToLongTimeString().Length > longest.Length ? next.DateLastModified.ToLongTimeString() : longest).Length;

            for (int i = 0; i < Media.Count; i++)
            {
                string result =
                    "|" + AlignLeft((i + 1).ToString(), indexWidth) +
                    "|" + AlignLeft(Media[i].File.Name, fileNameWidth) +
                    "|" + AlignLeft(Media[i].FileType.ToString(), fileExtensionWidth) +
                    "|" + AlignLeft(Media[i].DateLastModified.ToLongTimeString(), dateLastAccessedWidth) +
                    "|";
                Console.WriteLine(result);
            }
            return true;
        }

        string AlignLeft(string text, int width)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width);
            }
        }

        public override void SortByName()
        {
            Media = Media.OrderBy(t => t.File.Name).ToList();
        }

        public override void SortByExtension()
        {
            Media = Media.OrderBy(t => t.FileType.ToString()).ToList();
        }

        public override void SortByDateLastAccessed()
        {
            Media = Media.OrderByDescending(t => t.DateLastModified).ToList();
        }
    }
}
