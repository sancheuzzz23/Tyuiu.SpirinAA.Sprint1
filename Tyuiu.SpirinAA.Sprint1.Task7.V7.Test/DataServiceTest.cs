using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinAA.Sprint1.Task7.V7.Lib;

namespace Tyuiu.SpirinAA.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = -9.288;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, Math.Round(res, 3));
        }
    }
}
