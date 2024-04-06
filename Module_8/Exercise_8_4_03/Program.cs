using Exercise_8_4_03.Modules;
using System.Runtime.Serialization.Formatters.Binary;

namespace Exercise_8_4_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newContact = new Contact("Иван", 89001112233, "ivan@mail.ru");
            Console.WriteLine("Объект создан");

            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs=new FileStream(@"D:\Programming\Skillfactory\C#_projects\Module_8\FolderForFiles\Contact.dat",FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, newContact);
                Console.WriteLine("Объект сериализован");
            }
        }
    }
}
