using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BorodulinMS.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double res = double.MinValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine ())!= null)
                {
                    res = Convert.ToDouble(line) % 1;
                    if(double.TryParse(line, out double number))
                    {
                        if(number>res)
                        {
                            res = number;
                        }
                    }    
                   

                }
                return res;
            }
        }
    }
}
