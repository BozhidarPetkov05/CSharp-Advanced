namespace P04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, List<int>> generateRange = (start, end) =>
            {
                List<int> range = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    range.Add(i);
                }
                return range;
            };
            Func<string, int, bool> evenOrOdd = (condition, number) =>
            {
                if (condition == "even")
                {
                    return number % 2 == 0;
                }
                else
                {
                    return number % 2 != 0;
                }
            };
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            List<int> nums = generateRange(numbers[0], numbers[1]);
            foreach (var num in nums)
            {
                if (evenOrOdd(command, num))
                {
                    Console.Write($"{num} ");
                }        
            }
        }
    }
}