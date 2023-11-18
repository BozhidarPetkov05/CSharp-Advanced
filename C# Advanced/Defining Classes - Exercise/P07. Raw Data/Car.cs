using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, 
            double tire1pressure, int tire1Age,
            double tire2pressure, int tire2Age,
            double tire3pressure, int tire3Age,
            double tire4pressure, int tire4Age)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);

            Tires = new Tires[4];
            Tires[0] = new Tires(tire1pressure, tire1Age);
            Tires[1] = new Tires(tire2pressure, tire2Age);
            Tires[2] = new Tires(tire3pressure, tire3Age);
            Tires[3] = new Tires(tire4pressure, tire4Age);
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tires { get; set; }
    }
}
