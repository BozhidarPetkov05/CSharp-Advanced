namespace P02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            string[,] matrix = new string[rows, cols];
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    matrix[currentRow, currentCol] = input[currentCol];
                }
            }
            int squares = 0;
            for (int currentRow = 0; currentRow < rows - 1; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols - 1; currentCol++)
                {
                    string currentSymbol = matrix[currentRow, currentCol];
                    bool isEqualRight = currentSymbol == matrix[currentRow, currentCol + 1];
                    bool isEqualDown = currentSymbol == matrix[currentRow + 1, currentCol];
                    bool isEqualDiagonal = currentSymbol == matrix[currentRow + 1, currentCol + 1];
                    if (isEqualRight && isEqualDown && isEqualDiagonal)
                    {
                        squares++;
                    }

                }
            }
            Console.WriteLine(squares);
        }
    }
}