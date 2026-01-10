using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double sum = 0;
            int count = 0;
            bool foundRealNumbers = false;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] numbers = line.Split(' ');

                foreach (string numberStr in numbers)
                {
                    string trimmedNumber = numberStr.Trim();

                    // Пробуем преобразовать в double
                    if (double.TryParse(trimmedNumber,
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out double number))
                    {
                        // Проверяем, является ли число вещественным (дробным)
                        // По наличию точки или запятой в исходной строке
                        if (trimmedNumber.Contains('.') || trimmedNumber.Contains(','))
                        {
                            foundRealNumbers = true;
                            count++;
                            sum += number;
                        }
                    }
                }
            }

            if (!foundRealNumbers)
            {
                return 0; // Если вещественных чисел нет, возвращаем 0
            }

            double average = sum / count;
            return Math.Round(average, 3);
        }
    }
}