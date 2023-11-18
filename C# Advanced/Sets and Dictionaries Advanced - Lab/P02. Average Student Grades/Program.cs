namespace P02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < count; i++)
            {
                string[] input= Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<decimal>());
                }
                studentsGrades[name].Add(grade);
            }
            foreach (var item in studentsGrades)
            {
                string name = item.Key;
                List<decimal> grades = item.Value;
                decimal average = grades.Average();
                Console.WriteLine($"{name} -> {string.Join(" ", grades.Select(grade => $"{grade:f2}"))} (avg: {average:f2})");
            }
        }
    }
}