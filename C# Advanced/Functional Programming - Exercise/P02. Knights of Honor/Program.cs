namespace P02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string, string[]> printWithSir = (title, names) =>
            {
                foreach (string name in names)
                {
                    Console.WriteLine($"{title} {name}");
                }
            };
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            printWithSir("Sir", strings);
        }
    }
}