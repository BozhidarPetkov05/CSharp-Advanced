namespace SwapIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int item = int.Parse(Console.ReadLine());
                items.Add(item);
            }
            int[] indices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int index1 = indices[0];
            int index2 = indices[1];
            Swap(index1, index2, items);
            foreach (int item in items)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
        static void Swap<T>(int index1, int index2, List<T> items)
        {
            (items[index2], items[index1]) = (items[index1], items[index2]);
        }
    }
}