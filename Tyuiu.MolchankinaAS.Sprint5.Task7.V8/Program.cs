using Tyuiu.MolchankinaAS.Sprint5.Task7.V8.Lib;
namespace Tyuiu.MolchankinaAS.Sprint5.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask7V8.txt");
            Console.WriteLine("Исходный файл расположен: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Все заглавные русские буквы заменены на строчные.\n" + "Файл создан! Путь: " + res);
        }
    }
}
