namespace P02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(list);
            string input = Console.ReadLine();
            input = input.ToLower();
            while (input != "end")
            {
                string[] arguments = input.Split();
                string command = arguments[0];
                if (command == "add")
                {
                    int firstNum = int.Parse(arguments[1]);
                    int secondNum = int.Parse(arguments[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (command == "remove")
                {
                    int length = int.Parse(arguments[1]);
                    if (length <= stack.Count)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                input = Console.ReadLine();
                input = input.ToLower();
            }
            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}