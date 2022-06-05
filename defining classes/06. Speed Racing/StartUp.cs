using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

            
                        Car car = new Car(model, fuelAmount, fuelConsumption);
                        cars.Add(car);
                 
              
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] splitted = command.Split();
                string action = splitted[0];
                string carModel = splitted[1];
                double amountOfKm = double.Parse(splitted[2]);

                if(action == "Drive")
                {
                    Car currcar = cars.First(j => j.Model == carModel);
                    currcar.Drive(amountOfKm);
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
