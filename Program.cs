using System;
using System.Linq;

namespace _1._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(x => { return int.Parse(x); }).ToArray();

            Console.WriteLine($"{string.Join(", ", arr.Where(x => x % 2 == 0).OrderBy(x => x))}");
        }
    }
}
