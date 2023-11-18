namespace P01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> counts = new Dictionary<double, int>();
            for (int i = 0; i < values.Length; i++)
            {
                double current = values[i];
                if (counts.ContainsKey(current))
                {
                    counts[current]++;
                }
                else
                {
                    counts.Add(current, 1);
                }
            }
            foreach (KeyValuePair<double, int> pair in counts)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}