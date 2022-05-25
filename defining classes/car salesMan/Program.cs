using System;
using System.Collections.Generic;
using System.Linq;

namespace car_salesMan
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfEngine = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < linesOfEngine; i++)
            {
                
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                    string model = input[0];
                int power = int.Parse(input[1]);
                if (input.Length == 2)
                {
                    int displacement = int.Parse(input[2]);
              
                    Engine engine = new Engine(model, power, displacement);
                    engines.Add(engine);

                }
                else if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    Engine engine = new Engine(model, power,displacement,efficiency);
                    engines.Add(engine);

                }
                else if (input.Length==3)
                {
                    bool isDisplacement = int.TryParse(input[2], out int disp);
                    if(isDisplacement)
                    {
                        int displacement = disp;
                        Engine engine = new Engine(model, power, displacement);
                        engines.Add(engine);
                    }
                    else
                    {
                        string efficiency = input[2];
                        Engine engine = new Engine(model, power, efficiency);
                        engines.Add(engine);
                    }


                    

                }
                

            }
            int linesOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < linesOfCars; i++)
            {
                
                
                string[] input2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input2[0];
                string engineModel = input2[1];
                Engine engine = engines.First(x => x.Model == engineModel);
                if (input2.Length == 3)
                {
                    bool isWeight = int.TryParse(input2[2], out int weight);
                    if(isWeight)
                    {
                        Car car = new Car(model, engine, weight);
                        cars.Add(car);
                    }
                    else
                    {
                        string colour = input2[2];
                        Car car = new Car(model, engine, colour);
                        cars.Add(car);
                    }
                 

                }
                else if (input2.Length==4)
                {
                    int weight = int.Parse(input2[2]);
                    string colour = input2[3];
                   


                    Car car = new Car(model, engine, weight, colour);
                    cars.Add(car);
                }
                else if (input2.Length==2)
                {
                    Car car = new Car(model, engine);
                    cars.Add(car);
                }
            


            }

            foreach (var car in cars)
            {

                Console.WriteLine( car.ToString());
            }


        }
    }
}
