using System;

namespace _1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            Action<string[]> printNames = x => Console.WriteLine("Sir " + string.Join( Environment.NewLine + "Sir ", x ));
            printNames(names);
           
        }
    }
}
