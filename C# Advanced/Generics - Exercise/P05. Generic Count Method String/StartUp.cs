namespace CountString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < count; i++)
            {
                string current = Console.ReadLine();
                box.Add(current);
            }
            string itemToCompare = Console.ReadLine();
            Console.WriteLine(box.Count(itemToCompare));
        }
    }
}