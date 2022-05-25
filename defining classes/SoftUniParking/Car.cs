using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make,string model,int horseP,string regNum)
        {
            Make = make;
            Model = model;
            HorsePower = horseP;
            RegistrationNumber = regNum;
        }
       public string Make { get; set; }
        public string Model { get; set; }

       public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        static void ToString(string make,string model, int horsePower,string regNum)
        {
            Console.WriteLine($"Make: {make}\nModel: {model}\nHorsePower: {horsePower}\nRegistrationNumber: {regNum}"
);
        }

        public override string ToString()
        {
            return $"Make: {Make}\nModel: {Model}\nHorsePower: {HorsePower}\nRegistrationNumber: {RegistrationNumber}";
        }

    }
}
