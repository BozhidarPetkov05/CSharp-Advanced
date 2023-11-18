namespace P03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                elements.UnionWith(input);
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}