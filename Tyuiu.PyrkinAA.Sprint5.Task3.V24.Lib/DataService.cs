using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {

          
            double result = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
            result = Math.Round(result, 3);

          
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(result);
            }

           
            double value64 = 64.0;
            byte[] bytes = BitConverter.GetBytes(value64);

           
            return Convert.ToBase64String(bytes);
        }
    }
}