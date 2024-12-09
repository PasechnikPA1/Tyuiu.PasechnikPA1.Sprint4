﻿using Tyuiu.PasechnikPA1.Sprint4.Task3.V20.Lib;
namespace Tyuiu.PasechnikPA1.Sprint4.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 8, 7, 7, 8, 5 },
                                           { 4, 3, 5, 3, 6 },
                                           { 5, 3, 8, 6, 3 },
                                           { 6, 3, 8, 5, 4 },
                                           { 3, 6, 8, 3, 4 } };
            int res = ds.Calculate(array);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
