using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task4.V30.Lib
{
    public class DataService : ISprint5Task4V30
    {
        public double LoadFromDataFile(string path)
        {
            try
            {
            
                string data = File.ReadAllText(path);

              
                double x = double.Parse(data);

           
                double result = (Math.Pow(x, 3) - Math.Tan(x)) + 2.03 * x;

               
                result = Math.Round(result, 3);

                return result;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"Файл не найден по пути: {path}");
            }
            catch (FormatException)
            {
                throw new FormatException("Файл должен содержать вещественное число.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}