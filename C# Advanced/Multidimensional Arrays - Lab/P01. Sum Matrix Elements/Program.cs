using System.Numerics;
using System.Xml.Schema;

namespace P01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];
            int[,] matrix = new int[row, col];
            int sum = 0;
            for (int currentRow = 0; currentRow < row; currentRow++)
            {
                int[] rowInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int currentCol = 0; currentCol < col; currentCol++)
                {
                    int current = rowInput[currentCol];
                    matrix[currentRow, currentCol] = current;
                    sum += current;
                }
            }
            Console.WriteLine(row);
            Console.WriteLine(col);
            Console.WriteLine(sum);
        }
    }
}