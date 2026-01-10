using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PyrkinAA.Sprint5.Task2.V14.Lib
{
    public class DataService : ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
         
            string fileName = "OutPutFileTask2.csv";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

           
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < rows; i++)
                {
                    string line = "";

                    for (int j = 0; j < cols; j++)
                    {
                    
                        int value = matrix[i, j] > 0 ? 1 : 0;
                        line += value;

                      
                        if (j < cols - 1)
                        {
                            line += ";";
                        }
                    }

                    writer.WriteLine(line);
                }
            }


            return Path.GetFullPath(fileName);
        }
    }
}