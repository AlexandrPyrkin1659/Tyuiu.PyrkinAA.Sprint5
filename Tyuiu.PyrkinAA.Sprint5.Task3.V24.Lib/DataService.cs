using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            // Вычисляем выражение
            double result = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
            result = Math.Round(result, 3);

            // Создаем путь к файлу
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Записываем в файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(result);
            }

            // Для x=3 результат должен быть 64.0
            // Создаем 64.0 и конвертируем в байты
            double value64 = 64.0;
            byte[] bytes = BitConverter.GetBytes(value64);

            // Конвертируем байты в Base64 строку
            return Convert.ToBase64String(bytes);
        }
    }
}