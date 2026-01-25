using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            
            double res = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
            res = Math.Round(res, 3);

           
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(res);
            }

            return path;
        }
    }
}