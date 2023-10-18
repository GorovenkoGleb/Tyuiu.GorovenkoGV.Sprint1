using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.GorovenkoGV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExperssion()
        {
            DataService ds = new DataService();
            int time = 15000;
            int res = ds.SecondsToHours(time);

            double result = Convert.ToDouble(res);

            int wait = 4;
            Assert.AreEqual(wait, result);

        }
    }
}
