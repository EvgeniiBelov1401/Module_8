namespace Exercise_8_3_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Programming\Skillfactory\C#_projects\Module_8\FolderForFiles\Students.txt";
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("Олег");
                    sw.WriteLine("Иван");
                    sw.WriteLine("Егор");
                }
            }

            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str=sr.ReadLine())!=null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
