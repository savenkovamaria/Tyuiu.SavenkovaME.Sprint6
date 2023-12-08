using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint6.Task7.V13.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint6.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\saven\source\repos\Tyuiu.SavenkovaME.Sprint6\Tyuiu.SavenkovaME.Sprint6.Task7.V13\bin\Debug\InPutFileTask7V13.csv";
            int[,] wait = new int[,] { {-7, 4, -14, 5, -20, -15, 111, 6,
                    -9, -2 } , {8, -18, 16, -19, 16, -12, 111, -7, -2, -4 } , { -6, -2, -15, 13,
                    -19, 4, -13, 6, -1 , -13} , {-2 ,-1 , -18, 5, -8, -11, 7,  9, 3,
                    -17} , { -9, 18, 6, -3, 20, -18, -10, -5, -12, 11}, { 13, 10, -13, -1, -6, -15,
                    -16, -20, 16, 6} , { -20, -17, 7, -16, 14, 13, -6, 13, 12, 17}, {2,
                    -20, 13, 4, -20, -15, 111, 4, -17, 15}, { 13, 3, -14, -3, 19, 4, 19, 14, 12,
                    5} , { -5, 9, 3, 8, 8, -13, 111, 8, 4, -17} };
            int[,] res = ds.GetMatrix(path);
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void File()
        {
            string openedFile = @"C:\Users\saven\source\repos\Tyuiu.SavenkovaME.Sprint6\Tyuiu.SavenkovaME.Sprint6.Task7.V13\bin\Debug\InPutFileTask7V13.csv";
            FileInfo file = new FileInfo(openedFile);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
