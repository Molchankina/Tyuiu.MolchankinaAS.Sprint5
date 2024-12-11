using Tyuiu.MolchankinaAS.Sprint5.Task4.V26.Lib;
namespace Tyuiu.MolchankinaAS.Sprint5.Task4.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V26.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.LoadFromDataFile(path);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
