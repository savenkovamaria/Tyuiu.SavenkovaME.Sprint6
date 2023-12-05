using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SavenkovaME.Sprint6.Task4.V10.Lib
{
    public class DataService : ISprint6Task4V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] result = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((5 * x + 2.5) / (Math.Sin(x) + 3)) + 2 * x + Math.Cos(x);
                y = Math.Round(y, 2);
                result[count] = y;
                count++;
            }
            return result;
        }
    }
}
