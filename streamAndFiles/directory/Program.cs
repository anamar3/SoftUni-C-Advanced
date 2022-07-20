using System;
using System.IO;

namespace directory
{
    class Program
    {
        static void Main(string[] args)
        {
           // Directory.CreateDirectory("../../../MyFirstDirectory");
          //  Directory.CreateDirectory("../../../CoolBin");
            Directory.Move("../../../MyFirstDirectory", "../../../CoolBin");

        
        }
    }
}
