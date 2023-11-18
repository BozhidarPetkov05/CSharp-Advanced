using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
        public Engine(int horsepower, double cubicCapacity)
        {
			Horsepower = horsepower;
			CubicCapacity = cubicCapacity;
        }
        private int horsepower;

		public int Horsepower
		{
			get { return horsepower; }
			set { horsepower = value; }
		}
		private double cubicCapacity;

		public double CubicCapacity
		{
			get { return cubicCapacity; }
			set { cubicCapacity = value; }
		}

	}
}
