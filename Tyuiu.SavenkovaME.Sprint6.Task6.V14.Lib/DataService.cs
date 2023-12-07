using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader streamreader = new StreamReader(path))
            {
                string line;
                while ((line = streamreader.ReadLine()) != null)
                {
                    string[] array = line.Split(' ');
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i].Contains("z"))
                        {
                            resStr = resStr + " " + array[i];
                        }
                    }
                }
            }
            return resStr;
        }
    }
}
