using System.Diagnostics;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PyrkinAA.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            
            if (fileExists)
            {
                File.Delete(path);
            }

            
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                   
                    double denominator = 4 * x - 0.5;
                    double y;

                    
                    if (Math.Abs(denominator) < 1e-10) 
                    {
                        y = 0;
                    }
                    else
                    {
                        
                        y = (3 * Math.Cos(x)) / denominator
                            + Math.Sin(x)
                            - 5 * x
                            - 2;
                    }

                   
                    y = Math.Round(y, 2);

                 
                    string strY = y.ToString();
                    writer.WriteLine(strY);
                }
            }

           
            return path;
        }
    }
}
