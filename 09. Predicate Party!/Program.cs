using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> people = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToList();
    
            Func<string, string, bool> StartsWithh = (x, word) => x.StartsWith(word);

            Func<string, string, bool> EndsWithh = (x, word) => x.EndsWith(word);

            Func<string, int, bool> Length = (x, length) => x.Length == length;







            string command = string.Empty;
          
            while((command= Console.ReadLine())!="Party!")
            {
                string[] splitted = command.Split();

                if(splitted[0] == "Double")
                {
                    DoubleNames(splitted,people, StartsWithh, EndsWithh,Length);
                    
                }
                else if(splitted[0]=="Remove")
                {
                    RemoveNames(splitted,people,StartsWithh, EndsWithh,Length);
                }    
            }
            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
        }

        private static void RemoveNames(string[] splitted, List<string> people, Func<string,string,bool>StartsWith, Func<string, string, bool> EndsWith, Func<string, int, bool> Length)
        {
            if (splitted[1] == "Length")
            {
                int length = int.Parse(splitted[2]);
                people.RemoveAll(x => Length(x, length));
            }
            else if (splitted[1] == "StartsWith")
            {
               string word = splitted[2];
                people.RemoveAll(x => StartsWith(x, word));
            }
            else if (splitted[1] == "EndsWith")
            {
                string word = splitted[2];
                people.RemoveAll(x => EndsWith(x, word));
            }
        }

        private static void DoubleNames(string[] splitted, List<string> people, Func<string, string, bool> StartsWith, Func<string, string, bool> EndsWith, Func<string, int, bool> Length)
        {
            List<string> testt = new List<string>(people);
            if (splitted[1] == "Length")
            {
                int length = int.Parse(splitted[2]);
                int count = 0;
                foreach (var item in testt)
                {
                    count++;

                    if(Length(item, length))
                        {
                       
                        people.Insert(count,item);
                        count = 0;
                    }
                
                }
                
            }
            else if (splitted[1] == "StartsWith")
            {
                string word = splitted[2];
                int count = 0;
                foreach (var item in testt)
                {
                    count++;
                    if (StartsWith(item, word))
                    {
                        people.Insert(count , item);
                        count = 0;
                    }
                    
                }
            }
            else if (splitted[1] == "EndsWith")
            {
                string word = splitted[2];
                int count = 0;
                foreach (var item in testt)
                {
                    count++;
                    if (EndsWith(item, word))
                    {
                        people.Insert(count , item);
                        count = 0;
                    }
                }
            }
        }
    }
}
