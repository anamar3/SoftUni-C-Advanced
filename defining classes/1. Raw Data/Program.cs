using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} " +
            //    "{tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} " +
            //    "{tire4Age}"
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                Engine engine = new Engine(engineSpeed, enginePower);


                int cargoWeight = int.Parse(input[3]);
                string type = input[4];

                Cargo cargo = new Cargo(type,cargoWeight);

                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Tire[] tires = new Tire[]
                {
                    new Tire(tire1Age,tire1Pressure),
                    new Tire(tire2Age,tire2Pressure),
                    new Tire(tire3Age,tire3Pressure),
                    new Tire(tire4Age,tire4Pressure),
                };

                

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);

            }
            string command = Console.ReadLine();
            if(command== "flammable")
            {
                cars = cars.FindAll(x => x.Cargo1.Type == "flammable");
                foreach (var car in cars)
                {
                    if(car.Engine1.Power>250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else

            {
               cars = cars.FindAll(x => x.Cargo1.Type == "fragile");
                foreach (var car in cars)
                {
                    if(car.Tires.Any(x=> x.Pressure<1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
