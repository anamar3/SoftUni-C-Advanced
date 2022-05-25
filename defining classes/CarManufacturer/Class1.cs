using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        int year;
        double pressure;
        public int Year { get { return this.year; } set { this.year = value; } }
        public double Pressure { get { return this.pressure; } set { this.pressure = value; } }
        public Tire(int year,double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
    public class Engine
    {
        int horsePower;
double cubicCapacity;

        public int HorsePower { get { return this.horsePower; } set { this.horsePower = value; } }
        public double CubicCapacity { get { return this.cubicCapacity; } set { this.cubicCapacity = value; } }

        public Engine(int horsePower,double cubicCapacity)
        {
            this.horsePower = horsePower;
            this.cubicCapacity = cubicCapacity;
        }
    }
    public class Car
    {
        string make;
        string model;
        int year;
        double fuelQuantity;
        double fuelConsumption;

        Engine engine;
        Tire[] tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;

        }
        public Car(string make, string model, int year) : this()
        {
            this.Make =make;
            this.Model =model;
            this.Year = year;
        }

        public Car(string make, string model, int year,double fuelQuantity,double fuelConsumption):this(make,model,year)
        {
            this.fuelConsumption = fuelConsumption;
            this.fuelQuantity = fuelQuantity;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires): this(make,model,year,fuelQuantity,fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }


    public string Make { get { return this.make; } set { this.make = value; } }
    public string Model { get { return this.model; } set { this.model = value; } }
    public int Year { get { return this.year; } set { this.year = value; } }
    public double FuelQuantity { get { return this.fuelQuantity; } set { this.fuelQuantity = value; } }
    public double FuelConsumption { get { return this.fuelConsumption; } set { this.fuelConsumption = value; } }
        public Engine Engine { get { return this.engine; }set { this.engine = value; } }
        public Tire[] Tires { get { return this.tires; }set { this.tires = value; } } 


    public void Drive(double distance)
    {
        if (fuelQuantity - distance * fuelConsumption > 0)
        {
            fuelQuantity -= distance * fuelConsumption;
        }
        else
        {
            Console.WriteLine("Not enough fuel to perform this trip!");
        }
    }
    public string WhoAmI()
    {
        return $"Make: {this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}";

    }
}  
}
