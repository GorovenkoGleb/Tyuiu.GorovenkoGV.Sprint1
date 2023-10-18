using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint1.Task2.V7.Lib;

namespace Tyuiu.GorovenkoGV.Sprint1.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExperssion()
        {
            DataService ds = new DataService();
            int x = 10;
            var res = ds.CalculateSquareCircle(x);
            Assert.AreEqual(314 , res);
        }
    }
}
