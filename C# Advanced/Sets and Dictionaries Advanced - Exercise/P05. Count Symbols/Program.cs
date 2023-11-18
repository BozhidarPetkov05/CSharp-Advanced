namespace P05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> charCount = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (!charCount.ContainsKey(current))
                {
                    charCount.Add(current, 1);
                }
                else
                {
                    charCount[current]++;
                }
            }
            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}