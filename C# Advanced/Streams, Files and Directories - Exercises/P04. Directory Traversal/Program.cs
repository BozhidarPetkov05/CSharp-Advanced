namespace DirectoryTraversal
{
    using System;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensionsFile = new SortedDictionary<string, List<FileInfo>>();
            string[] files = Directory.GetFiles(inputFolderPath);
            foreach (string fileName in files)
            {
                FileInfo fileInfo = new FileInfo(fileName);
                if (!extensionsFile.ContainsKey(fileInfo.Extension))
                {
                    extensionsFile.Add(fileInfo.Extension, new List<FileInfo>());
                }
                extensionsFile[fileInfo.Extension].Add(fileInfo);
            }
            StringBuilder sb = new StringBuilder();
            foreach (var extensionFiles in extensionsFile.OrderByDescending(ef => ef.Value.Count))
            {
                sb.AppendLine(extensionFiles.Key);
                foreach (var file in extensionFiles.Value.OrderBy(f => f.Length))
                {
                    sb.AppendLine($"-{file.Name} - {(double)file.Length / 1024:f3}kb");

                }
            }
            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + reportFileName;
            File.WriteAllText(reportFileName, textContent);
        }
    }
}
