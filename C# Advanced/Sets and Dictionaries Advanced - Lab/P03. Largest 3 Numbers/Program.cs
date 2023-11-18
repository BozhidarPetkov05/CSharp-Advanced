namespace P03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            numbers.OrderByDescending(x => x).ToList();
            List<int> largest = numbers.OrderByDescending(x => x).Take(3).ToList();
            Console.Write(string.Join(" ", largest));
        }
    }
}