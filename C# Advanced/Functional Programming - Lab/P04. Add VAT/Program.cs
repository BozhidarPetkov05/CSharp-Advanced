namespace P04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> parser = s => double.Parse(s);
            Func<double, double> vat = n => n * 1.2;

            List<double> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .Select (vat)
                .ToList();
            foreach (double number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}