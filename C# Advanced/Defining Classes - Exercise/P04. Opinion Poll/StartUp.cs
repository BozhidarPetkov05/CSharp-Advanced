namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int linesOfInformation = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < linesOfInformation; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                if (age > 30)
                {
                    Person person = new Person(name, age);                 
                    people.Add(person);
                }
            }
            people = people.OrderBy(p => p.Name).ToList();
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}