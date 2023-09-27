using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinAA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.SpirinAA.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string value = "привет пока привет";
            DataService ds = new DataService();
            bool res = ds.CheckLastWordRepetiton(value);
            Assert.IsTrue(res);
        }
    }
}
