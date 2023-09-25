using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinAA.Sprint1.Task4.V17.Lib;

namespace Tyuiu.SpirinAA.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 69;
            double y = 1;
            double wait = 0.125;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
