using System;
using System.IO;

namespace memory_stream
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream stream = new MemoryStream();

            byte[] buffre = new byte[] { 1, 2, 3, 4, 5 };
            stream.Write(buffre,0,buffre.Length);

            byte[] read = new byte[buffre.Length];
            stream.Seek(0, SeekOrigin.Begin);

            stream.Read(read, 0, read.Length);

            Console.WriteLine(string.Join(',',read));
        }
    }
}
