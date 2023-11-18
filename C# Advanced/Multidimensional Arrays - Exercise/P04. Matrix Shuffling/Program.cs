using System.ComponentModel.DataAnnotations;

namespace P04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int rows = size[0];
                int cols = size[1];
                int[,] matrix = new int[rows, cols];
                for (int currentRow = 0; currentRow < rows; currentRow++)
                {
                    string currentInput = Console.ReadLine();
                    if (CheckForLetters(currentInput) == true)
                    {
                        int[] matrixInput = currentInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        for (int currentCol = 0; currentCol < cols; currentCol++)
                        {
                            int current = matrixInput[currentCol];
                            matrix[currentRow, currentCol] = current;
                        }
                    }
                }
                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] arguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string command = arguments[0];
                    int row1 = int.Parse(arguments[1]);
                    int col1 = int.Parse(arguments[2]);
                    int row2 = int.Parse(arguments[3]);
                    int col2 = int.Parse(arguments[4]);
                    if (Validate(command, row1, row2, col1, col2, matrix) == true)
                    {
                        int temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;
                        for (int currentRow = 0; currentRow < rows; currentRow++)
                        {
                            for (int currentCol = 0; currentCol < cols; currentCol++)
                            {
                                Console.Write($"{matrix[currentRow, currentCol]} ");
                            }
                            Console.WriteLine("");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }

            }




        }

        private static bool CheckForLetters(string currentInput)
        {
            bool isValid = true;
            try
            {
                int[] matrixInput = currentInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            catch (System.FormatException)
            {
                isValid = false;
                Console.WriteLine("Invalid input!");
            }
            return isValid;
        }

        private static bool Validate(string command, int row1, int row2, int col1, int col2, int[,] matrix)
        {
            bool isValid = true;
            if (command != "swap")
            {
                isValid = false;
            }
            if (row1 >= matrix.GetLength(0))
            {
                isValid = false;
            }
            if (row2 >= matrix.GetLength(0))
            {
                isValid = false;
            }
            if (col1 >= matrix.GetLength(1))
            {
                isValid = false;
            }
            if (col2 >= matrix.GetLength(1))
            {
                isValid = false;
            }
            return isValid;
        }

    }
}
