namespace P01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int currentRow = 0; currentRow < size; currentRow++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int currentCol = 0; currentCol < size; currentCol++)
                {
                    matrix[currentRow, currentCol] = input[currentCol];
                }
            }
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;
            for (int currentRow = 0; currentRow < size; currentRow++)
            {
                int current = matrix[currentRow, currentRow];
                firstDiagonalSum += current;
            }
            for (int currentCol = 0; currentCol < size; currentCol++)
            {
                int current = matrix[size - 1 - currentCol, currentCol];
                secondDiagonalSum += current;
            }
            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }
    }
}