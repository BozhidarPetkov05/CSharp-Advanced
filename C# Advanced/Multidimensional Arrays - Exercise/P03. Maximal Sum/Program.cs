using System.Numerics;
using System.Text;

namespace P03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    int current = input[currentCol];
                    matrix[currentRow, currentCol] = current;
                }
            }
            int biggestSquareSum = 0;
            int biggestSquareCoordinatesRow = 0;
            int biggestSquareCoordinatesCol = 0;
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    if (currentCol + 2 > cols - 1 || currentRow + 2 > rows - 1)
                    {
                        break;
                    }
                    else
                    {
                        int total = 0;
                        int firstRowSum = matrix[currentRow, currentCol] + matrix[currentRow, currentCol + 1] + matrix[currentRow, currentCol + 2];
                        int secondRowSum = matrix[currentRow + 1, currentCol] + matrix[currentRow + 1, currentCol + 1] + matrix[currentRow + 1, currentCol + 2];
                        int thirdRowSum = matrix[currentRow + 2, currentCol] + matrix[currentRow + 2, currentCol + 1] + matrix[currentRow + 2, currentCol + 2];
                        total += firstRowSum + secondRowSum + thirdRowSum;
                        if (total > biggestSquareSum)
                        {
                            biggestSquareSum = total;
                            biggestSquareCoordinatesRow = currentRow;
                            biggestSquareCoordinatesCol = currentCol;
                        }
                    }
                }
            }
            Console.WriteLine($"Sum = {biggestSquareSum}");
            Console.WriteLine($"{matrix[biggestSquareCoordinatesRow, biggestSquareCoordinatesCol]} {matrix[biggestSquareCoordinatesRow, biggestSquareCoordinatesCol + 1]} {matrix[biggestSquareCoordinatesRow, biggestSquareCoordinatesCol + 2]}");
            Console.WriteLine($"{matrix[biggestSquareCoordinatesRow + 1, biggestSquareCoordinatesCol]} {matrix[biggestSquareCoordinatesRow + 1, biggestSquareCoordinatesCol + 1]} {matrix[biggestSquareCoordinatesRow + 1, biggestSquareCoordinatesCol + 2]}");
            Console.WriteLine($"{matrix[biggestSquareCoordinatesRow + 2, biggestSquareCoordinatesCol]} {matrix[biggestSquareCoordinatesRow + 2, biggestSquareCoordinatesCol + 1]} {matrix[biggestSquareCoordinatesRow + 2, biggestSquareCoordinatesCol + 2]}");
        }
    }
}