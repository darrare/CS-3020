﻿using System;
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
            MediaCollection<Audio> audioFiles = new MediaCollection<Audio>();




            return;
            Currency a = new Currency(10, 14, 36);
            Currency b = new Currency(9, 500, 42);

            if (a < b)
            {
                Console.WriteLine("A is less than B");
            }

            Console.ReadLine();

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
