using System.Data;
using System.Threading.Channels;

namespace P05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, List<int>, List<int>> function = (command, numbers) =>
            {
                List<int> result = new List<int>();
                foreach (int num in numbers)
                {
                    if (command == "add")
                    {
                        result.Add(num + 1);
                    }
                    else if (command == "subtract")
                    {
                        result.Add(num - 1);
                    }
                    else if (command == "multiply")
                    {
                        result.Add(num * 2);
                    }
                    else if (command == "divide")
                    {
                        result.Add(num / 2);
                    }
                }
                return result;
            };
            
            Action<List<int>> print = numbers => 
                Console.WriteLine(string.Join(" ", numbers));

            List<int> numInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "print")
                {
                    print(numInput);
                }
                else
                {
                    numInput = function(command, numInput);
                }
            }
        }
    }
}