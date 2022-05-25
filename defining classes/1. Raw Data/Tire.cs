using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        public Tire(int age1,double tire1P)
        {
            
           Age = age1;
            Pressure = tire1P;

           
        }
       
       
        public int Age { get; set; }
        public double Pressure { get; set; }
    }
}
