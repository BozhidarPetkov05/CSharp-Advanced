namespace P02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valuesToEnqueue = values[0];
            int valuesToDequeue = values[1];
            int valueToCheck = values[2];

            Queue<int> numbers = new Queue<int>(input.Take(valuesToEnqueue));
            while (numbers.Count > 0 && valuesToDequeue > 0)
            {
                numbers.Dequeue();
                valuesToDequeue--;
            }
            if (numbers.Contains(valueToCheck))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}