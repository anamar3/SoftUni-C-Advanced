using System;
using System.Linq;

namespace _7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Func<string, int, bool> FilterNames = (x, length) => x.Length <= length;
            names = names.Where(x => FilterNames(x,length)).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,names));

             
        }
    }
}
