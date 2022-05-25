using Spectre.Console;
using System;

namespace CarManufacturer
{
    public class StartUp
    { 
        public static void Main(string[] args)
        {

            var calendar = new Calendar(2020, 10);
            AnsiConsole.Write(calendar);

            // Create a canvas
            var canvas = new Canvas(16, 16);

            // Draw some shapes
            for (var i = 0; i < canvas.Width; i++)
            {
                // Cross
                canvas.SetPixel(i, i, Color.White);
                canvas.SetPixel(canvas.Width - i - 1, i, Color.White);

                // Border
                canvas.SetPixel(i, 0, Color.Red);
                canvas.SetPixel(0, i, Color.Green);
                canvas.SetPixel(i, canvas.Height - 1, Color.Blue);
                canvas.SetPixel(canvas.Width - 1, i, Color.Yellow);
            }

            // Render the canvas
            AnsiConsole.Write(canvas);
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelConsumption, fuelQuantity);
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");

            var tires = new Tire[2]
                    {

                        new Tire(1, 2.5),
                        new Tire(1, 2.1),
                    };
            var engine = new Engine(560, 30033);

            var cara = new Car("Mustang", "Urus", 2012, 222, 2, engine, tires);

        }
    }
}
