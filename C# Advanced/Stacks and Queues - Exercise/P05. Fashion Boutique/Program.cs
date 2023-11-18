namespace P05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(clothesValue);
            int capacity = int.Parse(Console.ReadLine());
            int currentCapacity = 0;
            int total = 1;
            while (clothes.Count > 0)
            {
                int current = clothes.Pop();
                if (current + currentCapacity <= capacity)
                {
                    currentCapacity += current;
                }
                else
                {
                    currentCapacity = 0;
                    total++;
                    currentCapacity += current;
                }
            }
            Console.WriteLine(total);
        }
    }
}