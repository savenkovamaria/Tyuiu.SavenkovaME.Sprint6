using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint6.Task0.V20.Lib;

namespace Tyuiu.SavenkovaME.Sprint6.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 2;
            double result = ds.Calculate(x);
            Assert.AreEqual(6.125, result);
        }
    }
}
