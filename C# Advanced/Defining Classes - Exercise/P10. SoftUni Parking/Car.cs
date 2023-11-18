using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefining
{
    public class Car
    {
        public Car(string make, string model, int horsepower, string registrationNumber)
        {
            Make = make;
            Model = model;
            Horsepower = horsepower;
            RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
        public string RegistrationNumber { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Horsepower: {Horsepower}");
            sb.AppendLine($"RegistrationNumber: {RegistrationNumber}");
            return sb.ToString();
        }
    }
}
