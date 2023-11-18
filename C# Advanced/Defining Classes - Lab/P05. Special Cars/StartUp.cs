using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire> tires = new List<Tire>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            
            string tireInput;
            while ((tireInput = Console.ReadLine()) != "No more tires")
            {
                string[] arguments = tireInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                int tireOneAge = int.Parse(arguments[0]);
                double tireOnePressure = double.Parse(arguments[1]);
                int tireTwoAge = int.Parse(arguments[2]);
                double tireTwoPressure = double.Parse(arguments[3]);
                int tireThreeAge = int.Parse(arguments[4]);
                double tireThreePressure = double.Parse(arguments[5]);
                int tireFourAge = int.Parse(arguments[6]);
                double tireFourPressure = double.Parse(arguments[7]);

                int totalTireAge = tireOneAge + tireTwoAge + tireThreeAge + tireFourAge;
                double totalTirePressure = tireOnePressure + tireTwoPressure + tireThreePressure + tireFourPressure;

                Tire tire = new Tire(totalTireAge, totalTirePressure);
                tires.Add(tire);
            }

            string engineInput;
            while ((engineInput = Console.ReadLine()) != "Engines done")
            {
                string[] arguments = engineInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsepower = int.Parse(arguments[0]);
                double cubicCapacity = double.Parse(arguments[1]);
                Engine engine = new Engine(horsepower, cubicCapacity);
                engines.Add(engine);
            }

            string carsInput;
            while ((carsInput = Console.ReadLine()) != "Show special")
            {
                string[] arguments = carsInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                string make = arguments[0];
                string model = arguments[1];
                int year = int.Parse(arguments[2]);
                double fuelQuantity = double.Parse(arguments[3]);
                double fuelConsumption = double.Parse(arguments[4]);
                int engineIndex = int.Parse(arguments[5]);
                int tireIndex = int.Parse(arguments[6]);

                int currentTireAge = tires[tireIndex].Years;
                double currentTirePressure = tires[tireIndex].Pressure;

                int currentEngineHorsepower = engines[engineIndex].Horsepower;
                double currentEngineCubics = engines[engineIndex].CubicCapacity;

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, currentTireAge, currentTirePressure, currentEngineHorsepower, currentEngineCubics);
                cars.Add(car);
            }

            foreach (var currentCar in cars)
            {
                if (currentCar.Year >= 2017 && currentCar.EngineHorsepower > 330 && currentCar.TirePressure > 9 && currentCar.TirePressure < 10)
                {
                    currentCar.FuelQuantity -= (currentCar.FuelConsumption / 100) * 20;

                    Console.WriteLine($"Make: {currentCar.Make}");
                    Console.WriteLine($"Model: {currentCar.Model}");
                    Console.WriteLine($"Year: {currentCar.Year}");
                    Console.WriteLine($"HorsePowers: {currentCar.EngineHorsepower}");
                    Console.WriteLine($"FuelQuantity: {currentCar.FuelQuantity}");
                }             
            }
        }
    }
}