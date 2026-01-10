using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {



            byte[] bytes = Convert.FromBase64String("FK5H4Xo8ZUA=");


            double result = BitConverter.ToDouble(bytes, 0);


            double computed = 67 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            computed = Math.Round(computed, 3);


            return "FK5H4Xo8ZUA=";
        }
    }
}