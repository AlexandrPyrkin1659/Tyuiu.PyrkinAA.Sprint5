using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            
            decimal part1 = 67 * x * x * x;      
            decimal part2 = 0.23m * x * x;       
            decimal part3 = 1.04m * x;          

            decimal resultDecimal = part1 + part2 + part3; 
            resultDecimal = decimal.Round(resultDecimal, 3); 

            
            double result = (double)resultDecimal;

            
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(memoryStream))
            {
                writer.Write(result);
                bytes = memoryStream.ToArray();
            }

            
            return Convert.ToBase64String(bytes);
        }
    }
}