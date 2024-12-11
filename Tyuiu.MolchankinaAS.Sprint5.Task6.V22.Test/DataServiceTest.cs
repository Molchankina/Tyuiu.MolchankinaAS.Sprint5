using Tyuiu.MolchankinaAS.Sprint5.Task6.V22.Lib;
namespace Tyuiu.MolchankinaAS.Sprint5.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5;
            double result = Math.Round(Math.Sin(2 / (3 * x)) + Math.Pow(x, 2), 3);
            double wait = 25;
            Assert.AreEqual(wait, result);
        }
    }
}