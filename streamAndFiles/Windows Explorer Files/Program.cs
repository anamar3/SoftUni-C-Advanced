using System;
using System.IO;
using System.Linq;

namespace Windows_Explorer_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var fs = new FileStream(@"c:\windows\explorer.exe", FileMode.Open,FileAccess.Read))
            {
                Console.WriteLine("File content: ");

                var buf = new byte[16384];
               while (true)
                {
                    int bytesRead = fs.Read(buf);
                    if(bytesRead == 0)
                    {
                        break;
                    }
                    Console.WriteLine(string.Join(' ',buf.Take(bytesRead))) ;
                }
            }
        }
    }
}
