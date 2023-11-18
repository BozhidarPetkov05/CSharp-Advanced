namespace P01._Monster_Extermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> armours = new Queue<int>(Console.ReadLine().Split(",").Select(int.Parse)); 
            Stack<int> strikes = new Stack<int>(Console.ReadLine().Split(",").Select(int.Parse));
            int monstersKilled = 0;
            while (armours.Any() && strikes.Any())
            {
                int armour = armours.Dequeue();
                int strike = strikes.Pop();
                if (strike >= armour)
                {
                    monstersKilled++;
                    strike -= armour;
                    if (strikes.Any())
                    {
                        int nextStrike = strikes.Pop();
                        nextStrike += strike;
                        strikes.Push(nextStrike);
                    }
                    else if (strike > 0)
                    {
                        strikes.Push(strike);   
                    }
                }
                else
                {
                    armour -= strike;
                    armours.Enqueue(armour);
                }
            }
            if (!armours.Any())
            {
                Console.WriteLine("All monsters have been killed!");
            }
            if (!strikes.Any())
            {
                Console.WriteLine("The soldier has been defeated.");
            }
            Console.WriteLine($"Total monsters killed: {monstersKilled}");
        }
    }
}