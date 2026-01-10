using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task4.V30.Lib
{
    public class DataService : ISprint5Task4V30
    {
        public double LoadFromDataFile(string path)
        {
            try
            {
                
                string fileContent = File.ReadAllText(path);

                
                string cleanedContent = fileContent.Trim();

                
                if (string.IsNullOrEmpty(cleanedContent))
                {
                    throw new FormatException("Файл пустой или содержит только пробелы.");
                }

              
                double x = double.Parse(cleanedContent, CultureInfo.InvariantCulture);

               
                double xCubed = Math.Pow(x, 3);
                double tanX = Math.Tan(x);
                double result = (xCubed - tanX) + 2.03 * x;

              
                result = Math.Round(result, 3);

                return result;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }
            catch (FormatException)
            {
                
                string content = File.Exists(path) ? File.ReadAllText(path) : "файл не существует";
                throw new FormatException($"Невозможно преобразовать содержимое файла в число. Содержимое: '{content}'");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка: {ex.Message}");
            }
        }
    }
}