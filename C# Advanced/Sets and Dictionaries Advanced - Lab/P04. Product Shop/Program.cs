namespace P04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] splitted = input.Split(", ");
                string shop = splitted[0];
                string product = splitted[1];
                double price = double.Parse(splitted[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops[shop].Add(product, price);
                }
            }
            foreach (var shop in shops.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}