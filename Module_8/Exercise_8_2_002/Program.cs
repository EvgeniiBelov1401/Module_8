namespace Exercise_8_2_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GetCatalogs();
        }
        static void GetCatalogs()
        {
            string dirName = "D:\\";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Папки: ");
                string[]dirs = Directory.GetDirectories(dirName);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }    
                    Console.WriteLine();
                    Console.WriteLine("Файлы: ");
                string[]files= Directory.GetFiles(dirName);
                foreach(string file in files)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}
