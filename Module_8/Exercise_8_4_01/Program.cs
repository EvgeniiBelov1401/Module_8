namespace Exercise_8_4_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string StringValue;
            string FileName = @"D:\Programming\Skillfactory\C#_projects\Module_8\FolderForFiles\BinaryFile.bin";
            

            using (BinaryWriter writer = new BinaryWriter(File.Open(FileName, FileMode.Open)))
            {
                writer.Write($"Дата создания: {DateTime.Now} Операционная система: {Environment.OSVersion}");
            }
            if (File.Exists(FileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(FileName, FileMode.Open)))
                {
                    StringValue = reader.ReadString();
                }

                Console.WriteLine($"Инфо: {StringValue}");
            }
        }
    }
}
