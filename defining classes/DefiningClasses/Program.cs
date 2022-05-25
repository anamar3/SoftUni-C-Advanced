using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int result = DateModifier.CalculateDifference(firstDate, secondDate);
            Console.WriteLine(result);




            //Person person = new Person("Peter",20);
            //Person person2 = new Person("George",18);
            //Family family = new Family();
            //family.AddMember(person);
        }
    }
}
