using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            
            double result = 67 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;

            
            result = Math.Round(result, 3);

            
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result);
            }

            
            return path;
        }
    }
}