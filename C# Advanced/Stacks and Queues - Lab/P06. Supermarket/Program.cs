namespace P06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Queue<string> peopleToPay = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (peopleToPay.Count > 0)
                    {
                        Console.WriteLine(peopleToPay.Dequeue());
                    }
                }
                else
                {
                    peopleToPay.Enqueue(input);
                }
            }
            Console.WriteLine($"{peopleToPay.Count} people remaining.");
        }
    }
}