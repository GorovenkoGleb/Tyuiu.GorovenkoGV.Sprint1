using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint1.Task4.V10.Lib;

namespace Tyuiu.GorovenkoGV.Sprint1.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExperssion()
        {
            DataService ds = new DataService();
            double a = 5;
            double wait = 1.308;
            var result = ds.Calculate(a);
            var res = Math.Truncate(1000 * result) / 1000;
            Assert.AreEqual(wait, res);
        }
    }
}
