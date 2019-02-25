using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediaManagement
{
    class Program
    {
        static MediaCollection<Video> videoCollection = new MediaCollection<Video>();
        static MediaCollection<Audio> audioCollection = new MediaCollection<Audio>();
        static MediaCollection<Image> imageCollection = new MediaCollection<Image>();

        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                userInput = Menu();
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Scanning for videos:");
                        ScanMenu(MediaType.Video);
                        Console.WriteLine();
                        Console.WriteLine("Finished scanning... Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Scanning for audio:");
                        ScanMenu(MediaType.Audio);
                        Console.WriteLine();
                        Console.WriteLine("Finished scanning... Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Scanning for images:");
                        ScanMenu(MediaType.Image);
                        Console.WriteLine();
                        Console.WriteLine("Finished scanning... Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Scanning for all:");
                        ScanMenu(MediaType.All);
                        Console.WriteLine();
                        Console.WriteLine("Finished scanning... Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        LibraryMenu(videoCollection);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        LibraryMenu(audioCollection);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        LibraryMenu(imageCollection);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine("Thank you for using this program.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (userInput != 8);
        }

        static void LibraryMenu(MediaCollectionAbstract collection)
        {
            int userInput = 0;
            int input = 0;
            do
            {
                Console.Clear();
                if (!collection.PrintLibrary())
                    return;
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1. Sort by name.");
                Console.WriteLine("2. Sort by file extension.");
                Console.WriteLine("3. Sort by date last accessed.");
                Console.WriteLine("4. Touch file.");
                Console.WriteLine("5. Remove file.");
                Console.WriteLine("6. Use file.");
                Console.WriteLine("7. Back to main menu.");
                Console.WriteLine("----------------------------------------------");
                Console.Write("Input: ");
                if (!int.TryParse(Console.ReadLine(), out userInput) || userInput > 7 || userInput < 1)
                {
                    Console.WriteLine("You have entered an incorrect key. Try again.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (userInput == 7)
                {
                    break;
                }

                switch (userInput)
                {
                    case 1:
                        collection.SortByName();
                        break;
                    case 2:
                        collection.SortByExtension();
                        break;
                    case 3:
                        collection.SortByDateLastAccessed();
                        break;
                    case 4:
                        Console.WriteLine("What is the index of the file you want to touch?");
                        if (!int.TryParse(Console.ReadLine(), out input))
                        {
                            Console.WriteLine("You have entered an incorrect key. Try again.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        if (collection.TouchFile(input))
                            Console.WriteLine("You have touched the file.");
                        else
                            Console.WriteLine("You have entered an index out of range.");

                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("What is the index of the file you want to remove?");
                        if (!int.TryParse(Console.ReadLine(), out input))
                        {
                            Console.WriteLine("You have entered an incorrect key. Try again.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        if (collection.RemoveFile(input))
                            Console.WriteLine("You have removed the file.");
                        else
                            Console.WriteLine("You have entered an index out of range.");

                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("What is the index of the file you want to use?");
                        if (!int.TryParse(Console.ReadLine(), out input))
                        {
                            Console.WriteLine("You have entered an incorrect key. Try again.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        if (collection.UseFile(input))
                            Console.WriteLine("You have used the file.");
                        else
                            Console.WriteLine("You have entered an index out of range.");

                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Going back to main menu.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (userInput != 7);
        }

        static void ScanMenu(MediaType type)
        {
            List<string> paths = new List<string>();
            do
            {
                Console.WriteLine("Please input a full directory path that you want to scan:");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "go")
                {
                    break;
                }

                if (Directory.Exists(userInput))
                {
                    Console.WriteLine("Path added to scan options.\n");
                    paths.Add(userInput);
                    Console.WriteLine("Type GO to run scan. Or...");
                }
                else
                {
                    Console.WriteLine("Path does not exist, verify you have entered a valid path.");
                }
            } while (true);
            RunScan(type, paths);
        }

        static void RunScan(MediaType type, List<string> directories)
        {
            foreach (string path in directories)
            {
                switch (type)
                {
                    case MediaType.Audio:
                        RecursivelySearchForFileType(path, new FileType[] { (FileType)1, (FileType)0 });
                        break;
                    case MediaType.Video:
                        RecursivelySearchForFileType(path, new FileType[] { FileType.MP4, FileType.AVI });
                        break;
                    case MediaType.Image:
                        RecursivelySearchForFileType(path, new FileType[] { FileType.PNG, FileType.JPG });
                        break;
                    case MediaType.All:
                        RecursivelySearchForFileType(path, new FileType[] { FileType.MP3, FileType.WAV, FileType.MP4, FileType.AVI, FileType.PNG, FileType.JPG });
                        break;
                }
            }
        }

        static int Menu()
        {
            int userInput = 0;
            do
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1. Scan for videos (MP4, AVI).");
                Console.WriteLine("2. Scan for audio (MP3, WAV).");
                Console.WriteLine("3. Scan for images (PNG, JPG).");
                Console.WriteLine("4. Scan for all.");
                Console.WriteLine("5. Access video library.");
                Console.WriteLine("6. Access audio library.");
                Console.WriteLine("7. Access image library.");
                Console.WriteLine("8. Close program.");
                Console.WriteLine("----------------------------------------------");
                Console.Write("Input: ");
                if (!int.TryParse(Console.ReadLine(), out userInput) || userInput > 8 || userInput < 1)
                {
                    Console.WriteLine("You have entered an incorrect key. Try again.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }
                return userInput;
            } while (userInput > 8 || userInput < 1);
            return -1;
        }

        static void RecursivelySearchForFileType(string path, FileType[] types)
        {
            foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            {
                try
                {
                    foreach (FileType s in types)
                    {
                        foreach (FileInfo file in new DirectoryInfo(directory.FullName).GetFiles("*." + s.ToString().ToLower()))
                        {
                            Console.WriteLine(s.ToString() + " found - " + file.DirectoryName);
                            switch (s)
                            {
                                case FileType.WAV:
                                    audioCollection.Media.Add(new Audio(file.DirectoryName, file, s, DateTime.Now));
                                    break;
                                case FileType.MP3:
                                    audioCollection.Media.Add(new Audio(file.DirectoryName, file, s, DateTime.Now));
                                    break;
                                case FileType.MP4:
                                    videoCollection.Media.Add(new Video(file.DirectoryName, file, s, DateTime.Now));
                                    break;
                                case FileType.AVI:
                                    videoCollection.Media.Add(new Video(file.DirectoryName, file, s, DateTime.Now));
                                    break;
                                case FileType.PNG:
                                    imageCollection.Media.Add(new Image(file.DirectoryName, file, s, DateTime.Now));
                                    break;
                                case FileType.JPG:
                                    imageCollection.Media.Add(new Image(file.DirectoryName, file, s, DateTime.Now));
                                    break;
                            }
                        }
                    }
                    RecursivelySearchForFileType(directory.FullName, types);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("No access available to " + directory.FullName);
                }
            }
        }
    }
}
