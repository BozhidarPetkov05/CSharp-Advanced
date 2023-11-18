using System.Linq;

namespace P10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedSet<string>> sideUsers = new SortedDictionary<string, SortedSet<string>>();
            string command;
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                if (command.Contains('|'))
                {
                    string[] tokens = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string side = tokens[0];
                    string users = tokens[1];
                    if (!sideUsers.ContainsKey(side))
                    {
                        sideUsers.Add(side, new SortedSet<string>());
                    }
                    sideUsers[side].Add(users); 
                }
                else
                {
                    string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string side = tokens[0];
                    string users = tokens[1];
                    foreach (var sidUsers in sideUsers)
                    {
                        if (sidUsers.Value.Contains(users))
                        {
                            sidUsers.Value.Remove(users);
                            break;
                        }
                    }
                    if (!sideUsers.ContainsKey(side))
                    {
                        sideUsers.Add(side, new SortedSet<string>());
                    }
                    sideUsers[side].Add(users);
                    Console.WriteLine($"{users} joins the {side} side!");
                }
            }
            foreach (var sidUsers in sideUsers.OrderByDescending(su => su.Value.Count))
            {
                if (sidUsers.Value.Any())
                {
                    Console.WriteLine($"Side: {sidUsers.Key}, Members: {sidUsers.Value.Count}");
                    foreach (var user in sidUsers.Value)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
                
            }   
        }
    }
}