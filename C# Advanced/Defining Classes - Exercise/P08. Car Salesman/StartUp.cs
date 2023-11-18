namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int numOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfEngines; i++)
            {
                string[] engineInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = CreateEngine(engineInput);
                engines.Add(engine);
            }
            
            int numOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCars; i++)
            {
                string[] carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = CreateCar(carInput, engines);
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        static Car CreateCar(string[] carInput, List<Engine> engines)
        {
            Engine engine = engines.Find(x => x.Model == carInput[1]);
            Car car = new Car(carInput[0], engine);
            if (carInput.Length > 2)
            {
                int weight;
                bool isDigit = int.TryParse(carInput[2], out weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carInput[2];
                }
                if (carInput.Length > 3)
                {
                    car.Color = carInput[3];
                }
            }
            return car;
        }

        static Engine CreateEngine(string[] engineInput)
        {
            Engine engine = new Engine(engineInput[0], int.Parse(engineInput[1]));
            if (engineInput.Length > 2)
            {
                int displacement;
                bool isDigit = int.TryParse(engineInput[2], out displacement);
                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = engineInput[2];
                }
                if (engineInput.Length > 3)
                {
                    engine.Efficiency = engineInput[3];
                }
            }
            return engine;
        }
    }
}