namespace Exercise_8_2_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\evgen\OneDrive\Рабочий стол\testFolder");
            string newPath= @"C:\Users\evgen\OneDrive\Рабочий стол\NewFolder\testFolder";
            if (dirInfo.Exists && !Directory.Exists(newPath)) 
            {
                dirInfo.MoveTo(newPath);
            }
        }
    }
}
