using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Recursion
{
    class Program
    {
        static string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        //static string[] folderNames = new string[] { "A", "B", "C" };
        static int howDeep = "RYANISCOOL".Length;
        static int howManyPerLayer = 3;
        static string phrase = "RYANISCOOL";
        static string parentName = "FolderTree";
        static Random rand = new Random();

        static void Main(string[] args)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\" + parentName))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\" + parentName);
                GenerateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\" + parentName, 0);
            }
            else
            {
                FindFile(AppDomain.CurrentDomain.BaseDirectory + "\\" + parentName);
            }
        }

        static bool fileFound = false;
        static void FindFile(string path)
        {
            if (fileFound)
                return;

            foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            {
                try
                {
                    foreach (FileInfo file in new DirectoryInfo(directory.FullName).GetFiles())
                    {
                        fileFound = true;
                        Console.WriteLine("Found file in " + directory.FullName);
                    }
                    FindFile(directory.FullName);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("No access available to " + directory.FullName);
                }
            }
        }

        static void GenerateDirectory(string path, int layer)
        {
            if (layer == howDeep)
            {
                return;
            }
            List<string> folderNames = new List<string>();
            folderNames.Add(phrase[layer].ToString());
            var selection = alphabet.OrderBy(t => rand.Next(0, 5000)).ToList();
            for(int i = 0; i < howManyPerLayer - 1; i++)
            {
                folderNames.Add(selection[i].ToString());
            }
            foreach (string s in folderNames)
            {
                Directory.CreateDirectory(path + "\\" + s);
                GenerateDirectory(path + "\\" + s, layer + 1);
            }
        }
    }
}
