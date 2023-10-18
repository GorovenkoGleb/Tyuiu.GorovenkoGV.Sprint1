using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint1.Task7.V28.Lib;

namespace Tyuiu.GorovenkoGV.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpenssion()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 4;
            double wait = 1024.961;
            var result = ds.Calculate(x, y);
            var res = Math.Truncate(1000 * result) / 1000;
            Assert.AreEqual(wait, res);
        }
    }
}
