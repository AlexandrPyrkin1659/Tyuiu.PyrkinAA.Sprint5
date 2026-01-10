using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            // Вычисляем F(x) = 6.1x³ + 0.23x² + 1.04x
            double result = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;

            // Округляем до трёх знаков после запятой
            result = Math.Round(result, 3);

            // Создаем байтовый массив в памяти
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(memoryStream))
            {
                writer.Write(result);
                bytes = memoryStream.ToArray();
            }

            // Также сохраняем в файл (если нужно по заданию)
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
                File.WriteAllBytes(path, bytes);
            }
            catch
            {
                // Игнорируем ошибки записи файла
            }

            // Возвращаем Base64 строку содержимого
            return Convert.ToBase64String(bytes);
        }
    }
}