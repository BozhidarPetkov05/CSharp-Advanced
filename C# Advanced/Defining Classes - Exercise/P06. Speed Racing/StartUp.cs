namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < numOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, fuelConsumption);
                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, car);
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (arguments[0] == "Drive")
                {
                    string model = arguments[1];
                    double distance = double.Parse(arguments[2]);
                    if (cars.ContainsKey(model))
                    {
                        Car.Drive(cars, model, distance);
                    }
                }
            }
            foreach (KeyValuePair<string, Car> car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }
        }
    }

}