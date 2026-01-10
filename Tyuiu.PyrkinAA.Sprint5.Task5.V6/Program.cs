using System;
using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task5.V6.Lib;

namespace Tyuiu.PyrkinAA.Sprint5.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V6.txt";

            Console.WriteLine($"Путь к файлу: {path}");
            Console.WriteLine($"Файл существует: {File.Exists(path)}");

            if (!File.Exists(path))
            {
                Console.WriteLine("ОШИБКА: Файл не найден! Проверьте путь и наличие файла.");
                Console.WriteLine("Создайте папку C:\\DataSprint5\\ и скопируйте в неё файл.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nСодержимое файла:");
            Console.WriteLine("-----------------");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("-----------------");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine($"Среднее значение вещественных чисел = {result:F3}");
            Console.WriteLine($"Округленный результат = {result}");

            Console.ReadKey();
        }
    }
}