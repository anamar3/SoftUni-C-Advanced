using System;
using System.Collections.Generic;
using System.Text;

namespace car_salesMan
{
    class Car
    {
        public Car(string model,Engine engine, int weight):this(model,engine)
        {
            Weight = weight;
        }
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, int weight, string colour) : this(model, engine,weight)
        {

        
            Colour = colour;
        }

        public Car(string model, Engine engine, string colour) : this(model, engine)
        {
            Colour = colour;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Colour { get; set; }

        public override string ToString()
        {
            string displacement = Engine.Displacement.ToString();
            string eff = Engine.Efficiency;
            if(Engine.Displacement == null)
            {
                displacement = "n/a";
            }
            if(Engine.Efficiency == null)
            {
                eff = "n/a";
            }

            string colour = Colour;
            string weight = Weight.ToString();
            if (Colour == null)
            {
                colour = "n/a";
            }
            if (Weight == null)
            {
                weight = "n/a";
            }
            return $"{ Model}:\n { Engine.Model}:\n  Power: { Engine.Power}\n   Displacement: {displacement}\n   Efficiency: { eff}\n  Weight: { weight}\n  Color: { colour}";

        }



    }
}
