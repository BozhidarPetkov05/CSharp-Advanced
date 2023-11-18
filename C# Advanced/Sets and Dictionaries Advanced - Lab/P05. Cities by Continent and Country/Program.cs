namespace P05._Cities_by_Continent_and_Country
{
//3
//Europe Germany Berlin
//Europe Bulgaria Varna
//Africa Egypt Cairo
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> locations = new Dictionary<string, Dictionary<string, List<string>>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++) 
            {
                string current = Console.ReadLine();
                string[] splitted = current.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = splitted[0];
                string country = splitted[1];
                string city = splitted[2];
                if (!locations.ContainsKey(continent))
                {
                    locations.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!locations[continent].ContainsKey(country))
                {
                    locations[continent].Add(country, new List<string>());
                }
                locations[continent][country].Add(city);
            }
            foreach (var continent in locations)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {(string.Join(", ", country.Value))}");
                }
            }
        }
    }
}