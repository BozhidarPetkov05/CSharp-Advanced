namespace P08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "PARTY")
            {
                char firstLetter = input[0];
                if (Char.IsDigit(firstLetter) == true)
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
            }
            string people;
            while ((people = Console.ReadLine()) != "END")
            {
                if (vip.Contains(people))
                {
                    vip.Remove(people);
                }
                else if (regular.Contains(people))
                {
                    regular.Remove(people);
                }
            }
            int peopleWhoNoCome = vip.Count + regular.Count;
            Console.WriteLine(peopleWhoNoCome);
            foreach (var person in vip)
            {
                Console.WriteLine(person);
            }
            foreach (var person in regular)
            {
                Console.WriteLine(person);
            }
        }
    }
}