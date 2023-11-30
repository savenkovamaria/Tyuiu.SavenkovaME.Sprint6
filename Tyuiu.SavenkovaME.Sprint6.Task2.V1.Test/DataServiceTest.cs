using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint6.Task2.V1.Lib;

namespace Tyuiu.SavenkovaME.Sprint6.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = ds.GetMassFunction(start, stop).Length;
            double[] wait = new double[len];
            wait[0] = 20.36;
            wait[1] = 15.42;
            wait[2] = 10.99;
            wait[3] = 7.43;
            wait[4] = 4.33;
            wait[5] = 1;
            wait[6] = 0;
            wait[7] = -8.87;
            wait[8] = -13.03;
            wait[9] = -16.53;
            wait[10] = 0; 
            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
