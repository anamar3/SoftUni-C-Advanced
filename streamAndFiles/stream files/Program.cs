using System;
using System.IO;

namespace stream_files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writeIT = new StreamWriter("output.txt",true))
            {
                writeIT.WriteLine("Does it work?");
            }

            using(StreamReader reader = new StreamReader("input.txt"))
            {
                double index = 0;
        var text = reader.ReadLine();
                while (text != null)
                {
                    if (index % 2 == 1)
                    {

                    Console.WriteLine(text);
                        
                     }
                    index++;
                    text = reader.ReadLine();
                }
                
            
          
                }

        }
    }
}
