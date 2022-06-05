using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Reverse()
                .ToList();
            double theNumDevidedBy = double.Parse(Console.ReadLine());
            List<double> final = new List<double>();
            Predicate<double> isItDevisible = x => x % theNumDevidedBy==0;
            foreach (var item in numbers)
            {
                if(!isItDevisible(item))
                {
                   final.Add(item);
                }
            }
           
            Console.WriteLine(string.Join(' ',final ));
        }
    }
}
