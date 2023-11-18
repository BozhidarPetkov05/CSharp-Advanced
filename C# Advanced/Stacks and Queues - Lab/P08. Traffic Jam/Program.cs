namespace P08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command;
            int carsPassed = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < numberOfCars; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        carsPassed++;
                    }
                }
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}