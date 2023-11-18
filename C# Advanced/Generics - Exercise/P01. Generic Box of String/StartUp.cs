namespace BoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string current = Console.ReadLine();
                box.Add(current);
            }
            Console.WriteLine(box.ToString());
        }
    }
}