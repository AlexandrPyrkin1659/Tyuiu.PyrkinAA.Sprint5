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
                // Читаем весь текст из файла
                string fileContent = File.ReadAllText(path);

                // Удаляем пробелы в начале и конце
                string cleanedContent = fileContent.Trim();

                // Проверяем, что файл не пустой
                if (string.IsNullOrEmpty(cleanedContent))
                {
                    throw new FormatException("Файл пустой или содержит только пробелы.");
                }

                // Преобразуем строку в число
                // Используем InvariantCulture для правильного чтения чисел с точкой
                double x = double.Parse(cleanedContent, CultureInfo.InvariantCulture);

                // Вычисляем по формуле: y = (x³ - tg(x)) + 2.03x
                double xCubed = Math.Pow(x, 3);
                double tanX = Math.Tan(x);
                double result = (xCubed - tanX) + 2.03 * x;

                // Округляем до 3 знаков после запятой
                result = Math.Round(result, 3);

                return result;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }
            catch (FormatException)
            {
                // Читаем содержимое для отладки
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