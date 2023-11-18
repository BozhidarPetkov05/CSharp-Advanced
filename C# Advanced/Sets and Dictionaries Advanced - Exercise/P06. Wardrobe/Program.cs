namespace P06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] {" -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 1; j < input.Length; j++)
                {
                    string currentWear = input[j];
                    if (!wardrobe[color].ContainsKey(currentWear))
                    {
                        wardrobe[color].Add(currentWear, 0);
                    }
                    wardrobe[color][currentWear]++;
                }
            }
            string[] searched = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colorToSearch = searched[0];
            string clothToSearch = searched[1];
            foreach (var colorClothes in wardrobe)
            {
                Console.WriteLine($"{colorClothes.Key} clothes:");
                foreach (var wearCount in colorClothes.Value)
                {
                    string printItem = $"* {wearCount.Key} - {wearCount.Value}";
                    if (colorClothes.Key == colorToSearch && wearCount.Key == clothToSearch)
                    {
                        printItem += " (found!)";
                    }
                    Console.WriteLine(printItem);
                }
            }
        }
    }
}