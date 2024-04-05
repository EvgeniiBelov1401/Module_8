namespace Exercise_8_3_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Programming\Skillfactory\C#_projects\Module_8\Module_8\Exercise_8_3_01\Program.cs";
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
