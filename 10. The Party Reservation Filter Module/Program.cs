using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            string input = string.Empty;
            List<string> finalGuests = new List<string>();
            Dictionary<string, List<string>> filters = new Dictionary<string, List<string>>();

            while((input=Console.ReadLine()) != "Print")
            {
                string[] splitted = input.Split(';');
                string action = splitted[0];
                string filter = splitted[1];
                string parameter = splitted[2];

                if(action == "Add filter")
                {
                    if(!filters.ContainsKey(filter))
                    {
                        filters.Add(filter, new List<string>());
                    }
         
                        filters[filter].Add(parameter);
                   
                }
                else if(action == "Remove filter")
                {
                    filters[filter].Remove(parameter);
                }

            }

            foreach (var kvp in filters)
            {
                string filter = kvp.Key;

                if(filter == "Starts with")
                {
                   foreach (var parameter in kvp.Value)
                        {
                        guests = guests.Where(n => !n.StartsWith(parameter)).ToList();
                        }
               
                }
                else if (filter == "Ends with")
                {
                     foreach (var parameter in kvp.Value)
                        {
                        guests = guests.Where(n => !n.EndsWith(parameter)).ToList();
                    }
   }
                if (filter == "Contains")
                {
                         foreach (var parameter in kvp.Value)
                        {
                        guests = guests.Where(n => !n.Contains(parameter)).ToList();
                    }

                }
                if (filter == "Length")
                {
                      foreach (var parameter in kvp.Value)
                        {
                        guests = guests.Where(n => n.Length != int.Parse(parameter)).ToList();
                    }
  
                }
            }
            if (guests.Any())
            {
                Console.WriteLine(string.Join(' ', guests));
            }
        }
    }
}