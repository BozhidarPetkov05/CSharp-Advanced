namespace CountDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < count; i++)
            {
                double current = double.Parse(Console.ReadLine());
                box.Add(current);
            }
            double itemToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(itemToCompare));
        }
    }
}