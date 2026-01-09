using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;

namespace Tyuiu.PyrkinAA.Sprint5.Task0.V3.Lib
{
    public class DataService : ISprint5Task0V3
    {
        public string SaveToFileTextData(int x)
        {
           
            double y = -1.0 / 4.0 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4);

           
            y = Math.Round(y, 3);

            
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTaskO.txt";

          
            File.WriteAllText(path, y.ToString());

            return path;
        }
    }
}