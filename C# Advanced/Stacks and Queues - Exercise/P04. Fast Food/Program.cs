namespace P04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> clientsOrders = new Queue<int>(orders);
            Console.WriteLine(clientsOrders.Max());
            while (foodQuantity > 0 && clientsOrders.Count > 0)
            {
                int currentOrder = clientsOrders.Peek();
                if (foodQuantity >= currentOrder)
                {
                    foodQuantity -= currentOrder;
                    clientsOrders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (clientsOrders.Count > 0)
            {
                Console.Write("Orders left: ");
                Console.Write(string.Join(" ", clientsOrders));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}