namespace P04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int openingBracket = stack.Pop();
                    Console.WriteLine(input.Substring(openingBracket, i - openingBracket + 1));
                }
            }
        }
    }
}