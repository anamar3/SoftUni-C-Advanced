using System;
using System.IO;

namespace the_size_of_a_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirPath = Console.ReadLine();

            ReadDirectory(dirPath,0);
        }

        public static void ReadDirectory(string path,int level)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            
            FileInfo[] files = dirInfo.GetFiles();
            Console.WriteLine($"{new string(' ', level * 3)} {dirInfo.Name}");
            string[] subDirs = Directory.GetDirectories(path);
            foreach (var subDir in subDirs)
            {
                ReadDirectory(subDir,level+1);
            }
            
            foreach (var item in files)
            {
               
                Console.WriteLine($"{new string (' ', level*3+1)} {item.Name}");
                //Console.WriteLine($"{item.Length}");
               // Console.WriteLine($"{item.Extension}");
            }
        }
    }
}
