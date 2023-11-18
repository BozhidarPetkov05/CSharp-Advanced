namespace P02._Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] sea = new char[size, size];
            int shipRow = 0;
            int shipCol = 0;
            int tons = 0;
            for (int row = 0; row < size; row++)
            {
                string rowInput = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    char current = rowInput[col];
                    sea[row, col] = current;
                    if (current == 'S')
                    {
                        sea[row, col] = '-';
                        shipRow = row;
                        shipCol = col;
                    }
                }
            }
            string direction;
            bool wasInWhirpool = false;
            while ((direction = Console.ReadLine()) != "collect the nets")
            {
                if (direction == "up")
                {
                    if (shipRow == 0)
                    {
                        shipRow = sea.GetLength(0) - 1;
                    }
                    else
                    {
                        shipRow -= 1;
                    }
                    bool isNum = Char.IsNumber(sea[shipRow, shipCol]);
                    int num = 0;
                    if (isNum == true)
                    {
                        num = int.Parse(sea[shipRow, shipCol].ToString());
                    }
                    if (sea[shipRow, shipCol] == char.Parse(num.ToString()))
                    {
                        tons += num;
                        sea[shipRow, shipCol] = '-';    
                    }
                    else if (sea[shipRow, shipCol] == 'W')
                    {
                        tons = 0;
                        wasInWhirpool = true;
                        break;
                    }
                }
                else if (direction == "down")
                {
                    if (shipRow == sea.GetLength(0) - 1)
                    {
                        shipRow = 0;
                    }
                    else
                    {
                        shipRow += 1;
                    }
                    bool isNum = Char.IsNumber(sea[shipRow, shipCol]);
                    int num = 0;
                    if (isNum == true)
                    {
                        num = int.Parse(sea[shipRow, shipCol].ToString());
                    }
                    if (sea[shipRow, shipCol] == char.Parse(num.ToString()))
                    {
                        tons += num;
                        sea[shipRow, shipCol] = '-';
                    }
                    else if (sea[shipRow, shipCol] == 'W')
                    {
                        tons = 0;
                        wasInWhirpool = true;
                        break;  
                    }
                }
                else if (direction == "left")
                {
                    if (shipCol == 0)
                    {
                        shipCol = sea.GetLength(1) - 1;
                    }
                    else
                    {
                        shipCol -= 1;
                    }
                    bool isNum = Char.IsNumber(sea[shipRow, shipCol]);
                    int num = 0;
                    if (isNum == true)
                    {
                        num = int.Parse(sea[shipRow, shipCol].ToString());
                    }
                    if (sea[shipRow, shipCol] == char.Parse(num.ToString()))
                    {
                        tons += num;
                        sea[shipRow, shipCol] = '-';
                    }
                    else if (sea[shipRow, shipCol] == 'W')
                    {
                        tons = 0;
                        wasInWhirpool = true;
                        break;
                    }
                }
                else if (direction == "right")
                {
                    if (shipCol == sea.GetLength(1) - 1)
                    {
                        shipCol = 0;
                    }
                    else
                    {
                        shipCol += 1;
                    }
                    bool isNum = Char.IsNumber(sea[shipRow, shipCol]);
                    int num = 0;
                    if (isNum == true)
                    {
                        num = int.Parse(sea[shipRow, shipCol].ToString());
                    }
                    if (sea[shipRow, shipCol] == char.Parse(num.ToString()))
                    {
                        tons += num;
                        sea[shipRow, shipCol] = '-';
                    }
                    else if (sea[shipRow, shipCol] == 'W')
                    {
                        tons = 0;
                        wasInWhirpool = true;
                        break;
                    }
                }
            }
            sea[shipRow, shipCol] = 'S';
            if (wasInWhirpool == true)
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{shipRow},{shipCol}]");
            }
            else if (tons >= 20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else if (tons < 20 && wasInWhirpool == false)
            {
                int needed = 20 - tons;
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {needed} tons of fish more.");
            }
            if (tons > 0)
            {
                Console.WriteLine($"Amount of fish caught: {tons} tons.");
            }
            if (wasInWhirpool == false)
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        Console.Write(sea[row, col]);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}