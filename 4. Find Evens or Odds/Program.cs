using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int from = input[0];
            int to = input[1];

            string oddOrEven = Console.ReadLine();

            Predicate<int> isIToddOrEven = n => n % 2 == 0;
            List<int> final = new List<int>();

            for (int i = from; i <= to; i++)
            {
                if (oddOrEven == "odd")
                {
                    if(!isIToddOrEven(i))
                    {
                        final.Add(i);
                    }
                    
                }
                else
                {
                    if(isIToddOrEven(i))
                    {
                        final.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(' ',final));
        }
    }
}
