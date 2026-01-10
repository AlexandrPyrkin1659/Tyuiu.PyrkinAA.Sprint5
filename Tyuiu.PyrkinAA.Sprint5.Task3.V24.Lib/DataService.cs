using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
      
            double result = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;

     
            result = Math.Round(result, 3);

            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(memoryStream))
            {
                writer.Write(result);
                bytes = memoryStream.ToArray();
            }

            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
                File.WriteAllBytes(path, bytes);
            }
            catch
            {
                
            }

            return Convert.ToBase64String(bytes);
        }
    }
}