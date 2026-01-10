using System;
using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task4.V30.Lib;

namespace Tyuiu.PyrkinAA.Sprint5.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Пыркин А. А. | АСОиУб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5 | Задание #4 | Вариант #30                                    *");
            Console.WriteLine("* Выполнил: Пыркин А. А. | АСОиУб-23-2                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать значение из файла и вычислить по формуле:                    *");
            Console.WriteLine("* y = (x³ - tg(x)) + 2.03x                                                *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine($"Файл не найден: {path}");
                    Console.WriteLine("Создайте папку C:\\DataSprint5\\ и скопируйте туда файл.");
                    Console.ReadKey();
                    return;
                }

                DataService ds = new DataService();
                double result = ds.LoadFromDataFile(path);

                Console.WriteLine($"Файл: {path}");
                Console.WriteLine($"Прочитанное значение: {File.ReadAllText(path)}");
                Console.WriteLine($"Результат вычислений: {result:F3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}