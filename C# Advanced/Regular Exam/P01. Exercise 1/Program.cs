using System.Text;

namespace P01._Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> initialFuel = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> consumptionIndex = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> neededFuel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int neededFuelCount = neededFuel.Count();
            List<int> altitudes = new List<int>();
            for (int i = 1; i <= neededFuelCount; i++)
            {

                int fuel = initialFuel.Peek();
                int consumption = consumptionIndex.Peek();
                int needed = neededFuel.Peek();
                int result = fuel - consumption;
                if (result >= needed)
                {
                    initialFuel.Pop();
                    consumptionIndex.Dequeue();
                    neededFuel.Dequeue();
                    Console.WriteLine($"John has reached: Altitude {i}");
                    altitudes.Add(i);
                }
                else if (result < needed)
                {
                    Console.WriteLine($"John did not reach: Altitude {i}");
                    break;
                }
            }
            if (altitudes.Count > 0 && neededFuel.Count > 0 && neededFuel.Count < neededFuelCount)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.Write("Reached altitudes: ");
                foreach (var item in altitudes)
                {
                    if (item == altitudes[altitudes.Count - 1])
                    {
                        Console.Write($"Altitude {item}");
                    }
                    else
                    {
                        Console.Write($"Altitude {item}, ");
                    }
                }
                Console.WriteLine("");
            }
            else if (altitudes.Count == 0 && neededFuel.Count == neededFuelCount)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }
            else if (altitudes.Count > 0 && neededFuel.Count == 0)
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
        }
    }
}