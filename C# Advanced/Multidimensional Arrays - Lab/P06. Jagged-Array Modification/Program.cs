namespace P06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[currentRow] = input;
            }
            string commandInput = Console.ReadLine().ToLower();
            while (commandInput != "end")
            {
                string[] arguments = commandInput.Split();
                string command = arguments[0];
                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int valueToUse = int.Parse(arguments[3]);
                if (row < 0 || row > matrix.Length || col < 0 || matrix[row].Length <= col)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command == "add")
                    {
                        matrix[row][col] += valueToUse;
                    }
                    else if (command == "subtract")
                    {
                        matrix[row][col] -= valueToUse;
                    }
                }
                commandInput = Console.ReadLine().ToLower();
            }
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < matrix[currentRow].Length; currentCol++)
                {
                    Console.Write($"{matrix[currentRow][currentCol]} ");
                }
                Console.WriteLine("");
            }
        }
    }
}