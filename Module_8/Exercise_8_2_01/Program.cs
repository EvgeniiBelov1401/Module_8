﻿namespace Exercise_8_2_01
{
    internal class Program
    {
        private static object direct;

        static void Main(string[] args)
        {
            string dirName = "D:\\";
            if (Directory.Exists(dirName))
            {
                string[] direct = Directory.GetDirectories(dirName);
                string[] files = Directory.GetFiles(dirName);

                Console.WriteLine($"Кол-во папок: {direct.Length}\n" +
                    $"Кол-во файлов: {files.Length}\n");
            }

            string newDirName = "D:\\NewFolder";
            if (!Directory.Exists(newDirName))
            {
                Directory.CreateDirectory(newDirName);
                string[] direct = Directory.GetDirectories(dirName);
                string[] files = Directory.GetFiles(dirName);

                Console.WriteLine($"Кол-во папок: {direct.Length}\n" +
                    $"Кол-во файлов: {files.Length}\n");
            }
            

        }
    }
}
