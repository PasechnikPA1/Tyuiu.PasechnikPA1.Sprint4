using Tyuiu.PasechnikPA1.Sprint4.Task2.V9.Lib;
namespace Tyuiu.PasechnikPA1.Sprint4.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5, 4, 2, 7, 3 };
            int wait = 2048;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
