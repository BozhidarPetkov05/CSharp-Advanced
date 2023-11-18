namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] arguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                string model = arguments[0];
                
                int engineSpeed = int.Parse(arguments[1]);
                int enginePower = int.Parse(arguments[2]);
                
                int cargoWeight = int.Parse(arguments[3]);
                string cargoType = arguments[4];
                
                double tire1pressure = double.Parse(arguments[5]);
                int tire1age = int.Parse(arguments[6]);
                double tire2pressure = double.Parse(arguments[7]);
                int tire2age = int.Parse(arguments[8]);
                double tire3pressure = double.Parse(arguments[9]);
                int tire3age = int.Parse(arguments[10]);
                double tire4pressure = double.Parse(arguments[11]);
                int tire4age = int.Parse(arguments[12]);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                    tire1pressure, tire1age,
                    tire2pressure, tire2age,
                    tire3pressure, tire3age,
                    tire4pressure, tire4age);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            string[] filtered;
            if (command == "fragile")
            {
                filtered = cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .Select(c => c.Model)
                    .ToArray();
            }
            else
            {
                filtered = cars
                    .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                    .Select(c => c.Model)
                    .ToArray();
            }
            Console.WriteLine(string.Join(Environment.NewLine, filtered));
        }
    }
}