using System;
using System.Linq;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Func<double[], double> printNum = x =>
             {
                 double minNum = int.MaxValue;
                 foreach (var item in x)
                 { 
                     if (item < minNum)
                     {
                         minNum = item;
                     }
                     
                 }
                 return minNum;
             };
            Console.WriteLine( printNum(numbers));
            
        }
    }
}
