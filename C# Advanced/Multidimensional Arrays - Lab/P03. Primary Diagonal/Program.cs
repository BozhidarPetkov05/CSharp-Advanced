namespace P03._Primary_Diagonal
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
                    int current = input[currentCol];
                    matrix[currentRow, currentCol] = current;
                }
            }
            int sum = 0;
            for (int row = 0; row < size; row++)
            {
                int current = matrix[row, row];
                sum += current;
            }
            Console.WriteLine(sum);
        }
    }
}