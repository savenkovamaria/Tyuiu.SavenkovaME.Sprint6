using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint6.Task3.V5.Lib;

namespace Tyuiu.SavenkovaME.Sprint6.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[,] { { 30, -20, 7, -8, 9 }, { 32, 17, -14, -7, 33 }, 
                { 19, -19, -13, 14, -20}, { 11, 30, -1, 26, 6 }, { 30, -15, -20, -5, 15 } };
            int[,] wait = new int[,] { { 30, -20, -20, -8, 9 }, { 32, 17, -14, -7, 33 },
                { 19, -19, -13, 14, -20}, { 11, 30, -1, 26, 6 }, { 30, -15, 7, -5, 15 } };
            int[,] res = ds.Calculate(mtrx);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
