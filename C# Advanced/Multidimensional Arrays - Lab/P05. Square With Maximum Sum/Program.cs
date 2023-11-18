using System.Runtime.InteropServices;
using System.Xml;

namespace P05._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];
            int[,] matrix = new int[row, col];
            for (int rows = 0; rows < row; rows++)
            {
                int[] arrayInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < col; cols++)
                {
                    matrix[rows, cols] = arrayInput[cols];
                }
            }
            int maxSquareRow = 0;
            int maxSquareCol = 0;
            int maxSquareSum = int.MinValue;
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    int currentSquareSum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols];
                    if (currentSquareSum > maxSquareSum)
                    {
                        maxSquareSum = currentSquareSum;
                        maxSquareRow = rows;
                        maxSquareCol = cols;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxSquareRow, maxSquareCol]} {matrix[maxSquareRow, maxSquareCol + 1]} ");
            Console.WriteLine($"{matrix[maxSquareRow + 1, maxSquareCol]} {matrix[maxSquareRow + 1, maxSquareCol + 1]} ");
            Console.WriteLine(maxSquareSum);
        }
    }
}