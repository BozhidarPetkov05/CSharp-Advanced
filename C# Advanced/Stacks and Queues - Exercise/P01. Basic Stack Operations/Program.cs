namespace P01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valuesToPush = values[0];
            int valuesToPop = values[1];
            int valueToCheck = values[2];
    
            Stack<int> numbers = new Stack<int>(input.Take(valuesToPush));
            
            while (numbers.Count > 0 && valuesToPop > 0)
            {
                numbers.Pop();
                valuesToPop--;
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