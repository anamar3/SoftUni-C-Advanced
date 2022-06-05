using System;
using System.Collections.Generic;

namespace _11._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');
            Func<string, int, bool> firstFunc = (item, number) =>
            {
                int sum = 0;
                foreach (var ch in item)
                {
                    
                    sum += ch;
      
                }
                if (sum >= number)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            Func<string[], Func<string, int, bool>, string> secondFunc = (names, firstFunc) =>
               {

                   foreach (var item in names)
                   {
                       if (firstFunc(item, number))
                           return item;

                   }
                   return null;
               };

            Console.WriteLine( secondFunc(names, firstFunc));


        }
    }
}
