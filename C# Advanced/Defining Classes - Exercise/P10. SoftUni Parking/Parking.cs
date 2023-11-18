using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefining
{
    public class Parking
    {
        private Dictionary<string, Car> cars; 
        private int capacity { get; set; }
        public Parking(int capacity)
        {
            cars = new Dictionary<string, Car>();
        }
        public int Count
        {
            get { return cars.Count; }
        } 
        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (Count >= capacity)
            {
                return "Parking is full!";
            }
            this.cars.Add(car.RegistrationNumber, car);
            return $"Succesfully added new car {car.Make} {car.RegistrationNumber}";
        }
    }
}
