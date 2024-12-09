using Tyuiu.PasechnikPA1.Sprint4.Task1.V13.Lib;
namespace Tyuiu.PasechnikPA1.Sprint4.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[] nums = { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1 };
            int res = dataService.Calculate(nums), wait = 22;
            Assert.AreEqual(wait, res);
        }
    }
}
