using Tyuiu.MolchankinaAS.Sprint5.Task2.V19.Lib;
namespace Tyuiu.MolchankinaAS.Sprint5Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.MolchankinaAS.Sprint5\Tyuiu.MolchankinaAS.Sprint5.Task2.V19\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}