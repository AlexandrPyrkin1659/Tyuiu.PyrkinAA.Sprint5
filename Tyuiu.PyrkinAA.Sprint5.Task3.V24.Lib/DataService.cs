using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public byte[] SaveToFileTextData(int x)
        {
            // Вычисляем выражение
            double res = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
            res = Math.Round(res, 3);

            // Конвертируем double в байты
            byte[] bytes = BitConverter.GetBytes(res);

            // Создаем файл (по условию задачи)
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            File.WriteAllBytes(path, bytes);

            // Возвращаем байты
            return bytes;
        }
    }
}