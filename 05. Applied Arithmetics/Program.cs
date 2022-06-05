using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            

            string command = string.Empty;
            Func<int[], int[]> Add = (collection) =>
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    collection[i] += 1;
                }
                return collection;
            };

            Func<int[],int[]> multiply = (collection) =>
              {
                  for (int i = 0; i < collection.Length; i++)
                  {
                      collection[i] *= 2;
                  }
                  return collection;
              };

            Func<int[], int[]> subtract = (collection) =>
                  {
                      for (int i = 0; i < collection.Length; i++)
                      {
                          collection[i] -= 1;
                      }
                      return collection;
                  };

           Action< int[]> print = ( final) =>
            {
                Console.WriteLine(string.Join(' ',nums));
            };



           while(true)
            {
                command = Console.ReadLine();
                if(command== "add")
                {
                    nums = Add(nums);
                }
                else if( command == "multiply")
                {
                   nums = multiply(nums);
                }
                else if(command == "subtract")
                {
                    nums =  subtract(nums);
                }
                else if(command=="end")
                        {
                    return;
                }
                else if(command == "print")
                {
                    print(nums);
                }
            }


            
                            

        }
    }
}
