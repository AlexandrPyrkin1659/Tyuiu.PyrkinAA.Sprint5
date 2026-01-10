using System;
using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Пыркин А. А. | АСОиУб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Пыркин Алексей Андреевич | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 6.1x³ + 0.23x² + 1.04x, вычислить его значение   *");
            Console.WriteLine("* при x = 3, результат сохранить в бинарный файл OutPutFileTask3.bin и   *");
            Console.WriteLine("* вывести на консоль. Округлять до трёх знаков после запятой.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string filePath = ds.SaveToFileTextData(x);

            // Читаем результат из файла
            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            Console.WriteLine($"Файл: {filePath}");
            Console.WriteLine($"Результат: {result:F3}");

            Console.ReadKey();
        }
    }
}