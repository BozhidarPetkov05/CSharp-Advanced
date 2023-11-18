namespace P09._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            char[,] matrix = new char[size, size];
            int startRow = 0;
            int startCol = 0;
            int coalCount = 0;

            for (int currentRow = 0; currentRow < size; currentRow++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int currentCol = 0; currentCol < size; currentCol++)
                {
                    matrix[currentRow, currentCol] = input[currentCol];
                    if (input[currentCol] == 's')
                    {
                        startRow = currentRow;
                        startCol = currentCol;
                    }
                    else if (input[currentCol] == 'c')
                    {
                        coalCount++;
                        
                    }
                }
            }
            foreach (string direction in directions)
            {
                switch (direction)
                {
                    case "left":
                        if (startCol - 1 >= 0 && startCol - 1 <= size - 1)
                        {
                            startCol--;
                            char currentElement = matrix[startRow, startCol];
                            if (currentElement == 'e')
                            {
                                Console.WriteLine($"Game over! ({startRow}, {startCol})");
                                return;
                            }
                            else if (currentElement == 'c')
                            {
                                matrix[startRow, startCol] = '*';
                                coalCount--;
                                if (coalCount == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                                    return;
                                }
                            }
                        }
                        break;
                    case "right":
                        if (startCol+1 >=0 && startCol + 1 <= size - 1)
                        {
                            startCol++;
                        } 
                        break;
                    case "up":
                        if (startRow - 1 >= 0 && startRow - 1 <= size - 1)
                        {
                            startRow--;
                        }                       
                        break;
                    case "down":
                        if (startRow + 1 >= 0 && startRow + 1 <= size - 1)
                        {
                            startRow++;
                        }
                        break;
                }
            }
            Console.WriteLine($"{coalCount} coals left. ({startRow}, {startCol})");
        }
    }
}