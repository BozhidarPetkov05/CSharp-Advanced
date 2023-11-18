namespace P07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> children = Console.ReadLine().Split().ToList();
            Queue<string> queue = new Queue<string>(children);
            int tossCount = int.Parse(Console.ReadLine());
            int tosses = 0;
            while (queue.Count > 1)
            {
                tosses++;
                string current = queue.Dequeue();
                if (tosses == tossCount)
                {
                    tosses = 0;
                    Console.WriteLine($"Removed {current}");
                }
                else
                {
                    queue.Enqueue(current);
                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}