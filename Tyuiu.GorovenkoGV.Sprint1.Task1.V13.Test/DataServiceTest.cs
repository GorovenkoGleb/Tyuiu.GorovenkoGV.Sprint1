using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint1.Task1.V13.Lib;

namespace Tyuiu.GorovenkoGV.Sprint1.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExperssion()
        {
            DataService ds = new DataService();
            double x = 5;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);
        }
    }
}
