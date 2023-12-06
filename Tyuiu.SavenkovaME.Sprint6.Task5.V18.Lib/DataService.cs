using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SavenkovaME.Sprint6.Task5.V18.Lib
{
    public class DataService : ISprint6Task5V18
    {
        public int len;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader streamreader = new StreamReader(path))
            {
                string line;
                while ((line = streamreader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numarrays = new double[len];
            int index = 0;
            using (StreamReader streamreader = new StreamReader(path))
            {
                string line;
                double num = 0;
                while ((line = streamreader.ReadLine()) != null)
                {
                    
                    numarrays[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            
            numarrays = numarrays.Where(val => (val.ToString().Contains(","))).ToArray();
            return numarrays;
        }
    }
}
