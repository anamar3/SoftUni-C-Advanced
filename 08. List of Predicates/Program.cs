using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int toRange = int.Parse(Console.ReadLine());
            int [] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int, int[], bool> IsDivisible = (num, nums) =>
             {
                 bool j = true;
                 foreach (var item in nums)
                 {
                     if (num % item != 0)
                     {
                         j = false;
                     }
                 }
                 return j;

             };
            List<int> final = new List<int>();
            for (int i = 1; i <= toRange; i++)
            {
                if(IsDivisible(i, nums))
                {
                    final.Add(i);
                }
            }
            Console.WriteLine(string.Join(' ',final));
           



        }
    }
}
