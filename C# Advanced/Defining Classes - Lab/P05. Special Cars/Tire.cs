using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Tire
    {
        public Tire(int year, double pressure)
        {
			Years = year;
			Pressure = pressure;
        }
        private int years;

		public int Years
		{
			get { return years; }
			set { years = value; }
		}
		private double pressure;

		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}

	}
}
