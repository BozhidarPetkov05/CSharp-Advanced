namespace P06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songsToListen = new Queue<string>(songs);
            string[] input = Console.ReadLine().Split();
            while (true)
            {
                string command = input[0];
                if (command == "Play")
                {
                    if (songsToListen.Any())
                    {
                        songsToListen.Dequeue();
                    }
                    if (songsToListen.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if (command == "Add")
                {
                    string currentSong = string.Join(" ", input.Skip(1));
                    if (songsToListen.Contains(currentSong))
                    {
                        Console.WriteLine($"{currentSong} is already contained!");
                    }
                    else
                    {
                        songsToListen.Enqueue(currentSong);
                    }
                }
                else if (command == "Show")
                {
                    Console.Write(string.Join(", ", songsToListen));
                    Console.WriteLine("");
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}