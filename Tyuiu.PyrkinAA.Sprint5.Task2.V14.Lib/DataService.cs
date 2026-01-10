using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task2.V14.Lib
{
    public class DataService : ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
    
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask2.csv";
            string path = Path.Combine(tempPath, fileName);

          
            if (File.Exists(path))
            {
                File.Delete(path);
            }

           
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

         
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (int i = 0; i < rows; i++)
                {
                    string[] values = new string[cols];

                    for (int j = 0; j < cols; j++)
                    {
                       
                        values[j] = matrix[i, j] > 0 ? "1" : "0";
                    }

             
                    writer.WriteLine(string.Join(";", values));
                }
            }

            return path;
        }
    }
}