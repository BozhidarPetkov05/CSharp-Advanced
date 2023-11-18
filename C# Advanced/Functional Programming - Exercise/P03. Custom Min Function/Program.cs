namespace P03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<HashSet<int>, int> smallest = numbers => numbers.Min();
            HashSet<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();
            Console.WriteLine(smallest(numbers));
        }
    }
}