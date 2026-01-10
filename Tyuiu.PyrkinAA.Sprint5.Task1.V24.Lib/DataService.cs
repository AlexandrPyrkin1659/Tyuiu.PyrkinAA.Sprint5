using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PyrkinAA.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            
            string fileName = "OutPutFileTask1.txt";

            
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denominator = 4 * x - 0.5;
                    double result;

                  
                    if (Math.Abs(denominator) < 1e-10)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = (3 * Math.Cos(x)) / denominator
                                 + Math.Sin(x)
                                 - 5 * x
                                 - 2;
                    }

                   
                    result = Math.Round(result, 2);

                    
                    writer.WriteLine(result);
                }
            }

            
            return Path.GetFullPath(fileName);
        }
    }
}
