using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace P03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> list = input.Split().ToList();
            Stack<string> stack = new Stack<string>(list);
            Stack<string> finalStack = new Stack<string>(stack);
            while (finalStack.Count > 1)
            {
                int total = 0;
                int firstNum = int.Parse(finalStack.Pop());
                string operation = finalStack.Pop();
                int secondNum = int.Parse(finalStack.Pop());
                if (operation == "+")
                {
                    total += secondNum + firstNum;
                    finalStack.Push(total.ToString());
                }
                else if (operation == "-")
                {
                    total += firstNum - secondNum;
                    finalStack.Push(total.ToString());
                }
            }
            Console.WriteLine(finalStack.Pop());
        }
    }
}