namespace Exercise_8_3_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Programming\Skillfactory\C#_projects\Module_8\Module_8\Exercise_8_3_02\Program.cs";
            FileInfo fileInfo = new FileInfo(filePath);

            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"//Время запуска: {DateTime.Now}");
            }

            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
            //Console.WriteLine(fileInfo.LastAccessTime);
        }
    }
}
//Время запуска: 05.04.2024 19:51:37
//Время запуска: 05.04.2024 19:52:04
