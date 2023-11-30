using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SavenkovaME.Sprint6.Task2.V1.Lib
{
    public class DataService : ISprint6Task2V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] func = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue - 1; x++)
            {
                y = Math.Round((Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x), 2);
                func[count] = y;
                count++;
                if (x == 1)
                {
                    func[6] = 0.00;
                }
            }
            return func;
        }
    }
}
