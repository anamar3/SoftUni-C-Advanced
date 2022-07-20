using System;
using System.IO;

namespace computers_will_overtake_is
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("../../../Program.cs");
            File.WriteAllText("../../../Program.cs",$"{text}\n//Computers will overtake us");
        }
    }
}

//Computers will overtake us