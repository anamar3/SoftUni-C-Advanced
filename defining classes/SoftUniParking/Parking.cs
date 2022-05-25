using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        int capacity;
        private Dictionary<string, Car> cars;

        public int Count
        {
            get
            {

                return cars.Count;
    
            
            }
        }
    




        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary <string,Car>();
            
     
        }

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count == capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car.RegistrationNumber, car);
           
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string regNum)
        {
            if(!cars.ContainsKey(regNum))
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(regNum);
            return $"Successfully removed {regNum}";
        }

        public Car GetCar(string regNum)
        {
            

            return cars.FirstOrDefault(x => x.Key == regNum).Value;
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var item in RegistrationNumbers)
            {
                if(cars.ContainsKey(item))
                {
                    cars.Remove(item);
                }
            }
            
        }
        
    }
}
