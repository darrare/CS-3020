using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GenericsAndInterfaces_Demo
{
    class Program
    {
        enum Authors { RickAstley, MileyCyrus }
        static Dictionary<Authors, string> authorDirectories = new Dictionary<Authors, string>();

        static void Main(string[] args)
        {
            authorDirectories.Add(Authors.RickAstley, "D:\\Music\\TheBestStuff\\RickAstley\\");
            authorDirectories.Add(Authors.MileyCyrus, "D:\\Music\\WhyDidMyGFMakeMeDownloadThis\\MileyCyrus\\");

            PlayAuthor(Authors.RickAstley);
        }

        static void PlayAuthor(Authors author)
        {
            foreach (FileInfo audioFile in new DirectoryInfo(authorDirectories[author]).GetFiles("*.wav"))
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(audioFile.FullName);
                player.Play();
            }
            Console.ReadLine();
        }
    }
}
