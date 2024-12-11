using Tyuiu.MolchankinaAS.Sprint5.Task0.V9.Lib;
namespace Tyuiu.MolchankinaAS.Sprint5.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:C:\Users\user\source\repos\Tyuiu.MolchankinaAS.Sprint5\Tyuiu.MolchankinaAS.Sprint5.Task0.V9\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}