namespace P04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(current))
                {
                    numbers.Add(current, 1);
                }
                else
                {
                    numbers[current]++;
                }
            }
            int evenNumber = numbers.Single(n => n.Value % 2 == 0).Key;
            Console.WriteLine(evenNumber);
        }
    }
}