namespace Exercise_8_4_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath= @"D:\Programming\Skillfactory\C#_projects\Module_8\FolderForFiles\BinaryTest.bin";
            string StringValue = "Это бинарный файл";

            Console.WriteLine("Для создания бинарного файла нажмите 'Enter'");
            Console.ReadLine();
            CreateBinaryFile(filePath,StringValue);
            Console.Clear();
            Console.WriteLine("Бинарный файл был создан");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Для просмотра содержимого бинарного файла нажмите 'Enter'");
            Console.ReadLine();
            Console.Clear();
            ReadBinaryFile(filePath);


        }
        static void CreateBinaryFile(string filePath, string StringValue)
        {
            if (!File.Exists(filePath))
            {
                using (BinaryWriter create = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    create.Write(StringValue);
                }
            }
        }
        static void ReadBinaryFile(string filePath)
        {
            string readText="";
            if (File.Exists(filePath))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath,FileMode.Open)))
                {
                    readText= reader.ReadString();
                }
            }
            Console.WriteLine($"Содержимое файла: {readText}");
        }
    }
}
