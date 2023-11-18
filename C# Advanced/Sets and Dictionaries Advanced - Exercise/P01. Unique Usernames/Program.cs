namespace P01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string userName = Console.ReadLine();
                usernames.Add(userName);
            }
            foreach (string userName in usernames)
            {
                Console.WriteLine(userName);
            }
        }
    }
}