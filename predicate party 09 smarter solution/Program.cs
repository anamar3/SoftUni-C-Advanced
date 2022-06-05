using System;
using System.Collections.Generic;
using System.Linq;

namespace predicate_party_09_smarter_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<string> names = Console.ReadLine().Split(' ').ToList();

            string action = Console.ReadLine();

            while(action != "Party!")
            {
                string[] splitted = action.Split();

                string method = splitted[0];
                string operation = splitted[1];
                string value = splitted[2];


                if(method=="Double")
                {
                    List<string> doubledNames= names.FindAll(GetPredicate(operation, value));
                    if(!doubledNames.Any())
                    {
                        action = Console.ReadLine();
                        continue;
                    }
                    int index =names.FindIndex(GetPredicate(operation, value));
                    names.InsertRange(index, doubledNames);
                }
                else if(method=="Remove")
                {
                    names.RemoveAll(GetPredicate(operation, value));
                }


                action = Console.ReadLine();
            }
            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        private static Predicate<string> GetPredicate(string operation, string value)
        {
           if(operation=="StartsWith")
            {
                return x => x.StartsWith(value);
            }
          if(operation=="EndsWith")
            {
                return x => x.EndsWith(value);
            }
          
                int valueInt = int.Parse(value);
                return x => x.Length == valueInt;
           
        }
    }
}
