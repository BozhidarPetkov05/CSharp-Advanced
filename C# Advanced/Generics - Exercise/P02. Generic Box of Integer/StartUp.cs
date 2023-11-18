namespace BoxOfIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                int current = int.Parse(Console.ReadLine());
                box.Add(current);
            }
            Console.WriteLine(box.ToString());
        }
    }
}