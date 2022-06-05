using System;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAMount,double fuelcomp)
        {
            Model = model;
            FuelAmount = fuelAMount;
            FuelConsumptionPerKilometer = fuelcomp;
        }

        public string Model { get { return model; } set { this.model = value; } }
        public double FuelAmount { get { return fuelAmount; } set { this.fuelAmount = value; } }

        public double FuelConsumptionPerKilometer { get { return fuelConsumptionPerKilometer; } set { this.fuelConsumptionPerKilometer = value; } }
        public double TravelledDistance { get { return travelledDistance; } set { this.travelledDistance = value; } }

        public void Drive(double amountOfKm)
        {
            if (amountOfKm * this.FuelConsumptionPerKilometer > this.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= amountOfKm*this.FuelConsumptionPerKilometer;
                this.TravelledDistance += amountOfKm;
            }
        }
    }
}
