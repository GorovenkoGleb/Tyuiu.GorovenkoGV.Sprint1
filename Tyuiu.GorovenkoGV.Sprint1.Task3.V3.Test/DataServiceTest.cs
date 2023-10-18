using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint1.Task3.V3.Lib;

namespace Tyuiu.GorovenkoGV.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double length = 9;
            double width = 7.5;
            double height = 5;
            double wait = 337.5;
            var res = ds.ParallelepipedVolume(length, width, height);
            Assert.AreEqual(wait, res);

        }
    }
}
