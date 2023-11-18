using System.Globalization;

namespace P03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "1")
                {
                    int elementToPush = int.Parse(input[1]);
                    stack.Push(elementToPush);
                }
                else if (input[0] == "2")
                {
                    stack.Pop();
                }
                else if (input[0] == "3")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (input[0] == "4")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.Write(string.Join(", ", stack));
        }
    }
}