namespace SwapString
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();
                items.Add(item);
            }
            int[] indices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int index1 = indices[0];
            int index2 = indices[1];
            Swap(index1, index2, items);
            foreach (var item in items)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
        static void Swap<T>(int index1, int index2, List<T> items)
        {
            T temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }
    }
}