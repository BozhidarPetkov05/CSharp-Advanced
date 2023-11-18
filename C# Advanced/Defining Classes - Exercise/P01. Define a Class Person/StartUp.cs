namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Name = "Peter";
            peter.Age = 20;

            Person george = new Person();
            george.Name = "George";
            george.Age = 18;

            Person jose = new Person();
            jose.Name = "Jose";
            jose.Age = 43;

            Console.WriteLine($"{peter.Name} {peter.Age}");
            Console.WriteLine($"{george.Name} {george.Age}");
            Console.WriteLine($"{jose.Name} {jose.Age}");
        }
    }
}