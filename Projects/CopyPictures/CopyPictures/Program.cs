using System;


using System.Collections.Generic;


using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace CopyPictures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running application");
            List<string> paths = new List<string>();
            string[] extensions;

            if (!File.Exists(Application.StartupPath + "\\config.data"))
            {
                using (StreamWriter sr = new StreamWriter(Application.StartupPath + "\\config.data"))
                {
                    sr.WriteLine("*.png,*.jpg");
                    sr.WriteLine("C:\\users\\ryan.darras\\documents");
                    sr.WriteLine("C:\\users\\ryan.darras\\pictures");
                }
            }

            using (StreamReader sr = new StreamReader(Application.StartupPath + "\\config.data"))
            {
                string ext = sr.ReadLine();
                extensions = ext.Split(new char[] { ',', ' ' });

                string line;
                while((line = sr.ReadLine()) != null)
                {
                    paths.Add(line);
                }
            }
            foreach(string s in paths)
            {
                List<FileInfo> info = RecursivelySearchForImageType(s, extensions);
            }
            
            Console.WriteLine("Application finished");
            Console.ReadKey();
        }

        static List<FileInfo> RecursivelySearchForImageType(string path, string[] types)
        {
            List<FileInfo> media = new List<FileInfo>();
            foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            {
                
                try
                {
                    foreach (string s in types)
                    {
                        foreach (FileInfo file in new DirectoryInfo(directory.FullName).GetFiles(s))
                        {
                            Console.WriteLine("Found file " + file.Name + " in " + file.DirectoryName);
                            string parsedFileName = file.FullName.Split(new char[] { ':' })[1];
                            string parsedFilePath = parsedFileName.Split(new string[] { s }, 
                                StringSplitOptions.RemoveEmptyEntries)[0];
                            parsedFilePath = parsedFilePath.Remove(parsedFilePath.LastIndexOf("\\"));
                            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + parsedFilePath);
                            File.Copy(file.FullName, AppDomain.CurrentDomain.BaseDirectory + parsedFileName, true);
                            media.Add(file);
                        }
                    }
                    media.AddRange(RecursivelySearchForImageType(directory.FullName, types));   
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("No access available to " + directory.FullName);
                }
            }
            return media;
        }
    }
}
