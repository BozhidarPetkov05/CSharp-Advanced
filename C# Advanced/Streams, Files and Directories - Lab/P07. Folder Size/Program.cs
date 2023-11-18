﻿namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long size = CalculateFolderSize("../../../");
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"{size / 1024.0} KB ");
            }
            

            long CalculateFolderSize(string folderPath)
            {
                long bytes = 0;
                string[] files = Directory.GetFiles(folderPath);
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo info = new FileInfo(files[i]);
                    bytes += info.Length;
                }
                string[] directories = Directory.GetDirectories(folderPath);
                foreach (var directoryPath in directories)
                {
                    bytes += CalculateFolderSize(directoryPath);
                }
                return bytes;
            }
        }
    }
}