using System;
using System.IO;

namespace _01.Odd_Lines
{
    public class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"..\..\..\firstText.txt");
      
            
            using (reader)
            {
                int line = 0;
                var writer = new StreamWriter(@"..\..\..\IwriteHere.txt");
                using (writer)
                {
                    while (true)
                    {
                        string thisLine = reader.ReadLine();
                        if (thisLine == null)
                        {
                            break;
                        }
                        if (line / 2 != 0)
                        {

                            writer.WriteLine(thisLine);
                            writer.Flush();

                        }
                        line++;
                    }
                }
            }
            }
        }
}
