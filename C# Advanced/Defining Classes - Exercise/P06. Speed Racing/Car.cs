using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumption;
            TravelledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
        public static void Drive(Dictionary<string, Car> cars, string model, double distance)
        {
            double fuelAmount = cars[model].FuelAmount;
            double fuelConsumption = cars[model].FuelConsumptionPerKilometer;
            if (fuelConsumption * distance > fuelAmount )
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                cars[model].FuelAmount -= distance * fuelConsumption;
                cars[model].TravelledDistance += distance;
            }
        }
    }
}
