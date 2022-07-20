using System;
using System.IO;

namespace GetTheSizeOFaFolder__nakov
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal folderSize = CalcFolderSize(@"C:\Users\PC\OneDrive\Pictures");
            Console.WriteLine(folderSize / 1024);
            Console.WriteLine(folderSize/(1024*1024) + "mg");
        }

        static decimal CalcFolderSize(string path)
        {
            decimal folderSize = 0;
            var dirInfo = new DirectoryInfo(path);
            foreach (var item in dirInfo.EnumerateFiles("*.*", SearchOption.AllDirectories))
            {
                folderSize = folderSize + item.Length;
            }
            return folderSize;
        }
    }
}
