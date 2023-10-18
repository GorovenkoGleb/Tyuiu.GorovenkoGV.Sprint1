using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GorovenkoGV.Sprint1.Task7.V28.Lib
{
    public class DataService : ISprint1Task7V28
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow(Math.Cos(Math.Sin(1/x)), 2)+Math.Pow(y, x);
            var result = Math.Truncate(1000 * res) / 1000;
            return result;
        }
    }
}
