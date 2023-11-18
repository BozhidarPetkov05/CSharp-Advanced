namespace EvenLines
{
    using System;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            using StreamReader stramReader = new StreamReader(inputFilePath);
            
            string line = string.Empty;
            int count = 0;
            while (line != null)
            {
                line = stramReader.ReadLine();
                if (count % 2 == 0)
                {
                    string replacedSymbols = ReplaceSymbols(line);
                    string reversedWords = ReversedWords(replacedSymbols);
                    sb.Append(reversedWords);
                }
                count++;
            }
            return sb.ToString().TrimEnd();
        }

        public static string ReplaceSymbols(string line)
        {
            StringBuilder sb = new StringBuilder(line);
            char[] symbolsToReplace = {'-', ',', '.', '!', '?'};
            foreach (char symbol in symbolsToReplace)
            {
                sb = sb.Replace(symbol, '@');
            }
            return sb.ToString();
        }
        public static string ReversedWords(string words)
        {
            string[] reversedWords = words
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();
            return string.Join(" ", reversedWords);
        }

    }
}
