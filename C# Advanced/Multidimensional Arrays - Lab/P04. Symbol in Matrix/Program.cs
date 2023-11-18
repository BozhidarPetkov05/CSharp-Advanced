namespace P04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];
            for (int rows = 0; rows < size; rows++) 
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    string current = input[col].ToString();
                    matrix[rows, col] = current;
                }
            }
            string characterToSearch = Console.ReadLine();
            bool isFound = false;
            for (int rows = 0; rows < size; rows++)
            {
                for (int col = 0; col < size; col++)
                {
                    string current = matrix[rows, col];
                    if (current == characterToSearch)
                    {
                        Console.WriteLine($"({rows}, {col})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound == true)
                {
                    break;
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{characterToSearch} does not occur in the matrix");
            }
        }
    }
}