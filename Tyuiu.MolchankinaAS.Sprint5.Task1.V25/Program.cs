using Tyuiu.MolchankinaAS.Sprint5.Task1.V25.Lib;
namespace Tyuiu.MolchankinaAS.Sprint5.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

            int startValue = -5;
            int stopValue = 5;

            string filePath = dataService.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"\nРезультаты сохранены в файл: {filePath}");
            Console.WriteLine("************************************************************************");
            Console.ReadLine();
        }
    }
}
