using System;

namespace defining_classes5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Chan"; //set-vame go v setter-a
            var name = person.Name;//vzimame go ot getter -a

            Console.WriteLine(person.Name);

        }
        class Person
        {
            private string name;

            public string Name
            {
                get
                {
                    return this.name;
                }
                set { this.name = value; }
            }
        }
    }
}
