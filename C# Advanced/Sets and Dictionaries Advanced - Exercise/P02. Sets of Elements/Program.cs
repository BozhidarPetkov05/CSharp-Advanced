namespace P02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            int[] count = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int firstCount = count[0];
            int secondCount = count[1];
            for (int i = 0; i < firstCount; i++)
            {
                int current = int.Parse(Console.ReadLine());
                set1.Add(current);
            }
            for (int i = 0; i < secondCount; i++)
            {
                int current = int.Parse(Console.ReadLine());
                set2.Add(current);
            }
            set1.IntersectWith(set2);
            Console.Write(string.Join(" ", set1));

        }
    }
}