using System;
using System.IO;

namespace split_File
{
    class Program
    {
        static void Main(string[] args)
        {
            int bytes = 1;
            Console.Write("How many parts do you want?");
            int n = int.Parse(Console.ReadLine());
            using (FileStream stream = new FileStream("../../../input.txt", FileMode.Open))
            {
                long fileLength = (long)stream.Length / n;

                for (int i = 0; i < n; i++)
                {
                    int readBytes = 0;
                    using (FileStream newFile = new FileStream($"../../../input{i}.txt", FileMode.Create))
                    {
                        while (readBytes < fileLength)
                        {


                            var data = new byte[bytes];
                            stream.Read(data, 0, data.Length);

                            newFile.Write(data, 0, data.Length);
                            readBytes += data.Length;
                        }
                    }

                }
            }
        }
    
    }
}
