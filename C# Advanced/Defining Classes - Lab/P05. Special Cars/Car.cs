using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, int tireAge, double tirePressure, int engineHorsepower, double engineCubics)
        {
			Make = make;
			Model = model;
			Year = year;
			FuelQuantity = fuelQuantity;
			FuelConsumption = fuelConsumption;
			TireAge = tireAge;
			TirePressure = tirePressure;
			EngineHorsepower = engineHorsepower;
			EngineCubics = engineCubics;
        }
        private string make;

		public string Make
		{
			get { return make; }
			set { make = value; }
		}
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}
		private double fuelQuantity;

		public double FuelQuantity
		{
			get { return fuelQuantity; }
			set { fuelQuantity = value; }
		}
		private double fuelConsumption;

		public double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}
		private int tireAge;

		public int TireAge
		{
			get { return tireAge; }
			set { tireAge = value; }
		}
		private double tirePressure;

		public double TirePressure
		{
			get { return tirePressure; }
			set { tirePressure = value; }
		}
		private int engineHorsepower;

		public int EngineHorsepower
		{
			get { return engineHorsepower; }
			set { engineHorsepower = value; }
		}
		private double engineCubics;

		public double EngineCubics
		{
			get { return engineCubics; }
			set { engineCubics = value; }
		}

	}
}
