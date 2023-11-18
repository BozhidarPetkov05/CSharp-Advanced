namespace P05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> numbersQueue = new Queue<int>(numbers);
            List<int> evenNumbers = new List<int>();
            while (numbersQueue.Count > 0)
            {
                int current = numbersQueue.Dequeue();
                if (current%2 == 0)
                {
                    evenNumbers.Add(current);
                }
            }
            Console.Write(string.Join(", ", evenNumbers));
        }
    }
}