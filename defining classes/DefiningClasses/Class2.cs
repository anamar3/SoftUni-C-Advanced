using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }
        public void AddMember(Person person)
        {
            People.Add(person);
        }
        public Person GetOldestMember()
        {
            int oldestMember = int.MinValue;
            Person personTOReturn = null;
            for (int i = 0; i < People.Count; i++)
            {
                if(People[i].Age > oldestMember)
                {
                    personTOReturn = People[i];
                    oldestMember = People[i].Age;
                }
            }
            return personTOReturn;
        }
    }
}
