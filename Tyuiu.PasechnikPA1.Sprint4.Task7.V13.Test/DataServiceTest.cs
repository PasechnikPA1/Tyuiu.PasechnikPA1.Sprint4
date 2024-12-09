using Tyuiu.PasechnikPA1.Sprint4.Task7.V13.Lib;
namespace Tyuiu.PasechnikPA1.Sprint4.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "159357246";

            int res = ds.Calculate(n, m, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
