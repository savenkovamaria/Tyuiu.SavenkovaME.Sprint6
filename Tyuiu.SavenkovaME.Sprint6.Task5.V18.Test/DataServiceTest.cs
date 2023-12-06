using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SavenkovaME.Sprint6.Task5.V18.Lib;

namespace Tyuiu.SavenkovaME.Sprint6.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            string path = @"C:\Users\saven\source\repos\Tyuiu.SavenkovaME.Sprint6\Tyuiu.SavenkovaME.Sprint6.Task5.V18\bin\Debug\InPutFileTask5V18.txt";
            DataService ds = new DataService();
            double[] wait = new double[] { -14.32, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, 13.83,
                12.76, 8.86, -1.49 };
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\Users\saven\source\repos\Tyuiu.SavenkovaME.Sprint6\Tyuiu.SavenkovaME.Sprint6.Task5.V18\bin\Debug\InPutFileTask5V18.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
