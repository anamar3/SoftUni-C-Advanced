using System;

namespace _3._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            GiveUpper(text, x => Console.WriteLine(x));
        }
        public static void GiveUpper(string[] text, Action<string> backk)
        {
            foreach (var item in text)
            {
                if (char.IsUpper(item[0]))
                {
                    backk(item);
                }
            }
        }
    }
}
