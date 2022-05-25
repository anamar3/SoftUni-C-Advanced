using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        string model;

        public Car(string model,Engine engine,Cargo cargo,Tire [] tires)
        {
            Model = model;
            Engine1 = engine;
            Cargo1 = cargo;
            Tires = tires;
        }
        public string Model { get; set; }
        public Engine Engine1 { get; set; }
        public Cargo Cargo1 { get; set; }
        public  Tire [] Tires { get; set; }
    }
}
