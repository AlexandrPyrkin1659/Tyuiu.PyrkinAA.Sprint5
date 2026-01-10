using Tyuiu.PyrkinAA.Sprint5.Task7.V17.Lib;
using System;

namespace Tyuiu.PyrkinAA.Sprint5.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Пыркин А.А. | Группа";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Пыркин А.А. | Группа                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V17.txt. Удалить все        *");
            Console.WriteLine("* удвоенные буквы 'нн'. Полученный результат сохранить в файл             *");
            Console.WriteLine("* OutPutDataFileTask7V17.txt.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V17.txt";

            Console.WriteLine($"Входной файл: {inputPath}");
            Console.WriteLine($"Файл существует: {File.Exists(inputPath)}");

            if (!File.Exists(inputPath))
            {
                Console.WriteLine("ОШИБКА: Входной файл не найден! Проверьте путь и наличие файла.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nИсходный текст:");
            Console.WriteLine("-----------------");
            string originalText = File.ReadAllText(inputPath);
            Console.WriteLine(originalText);
            Console.WriteLine("-----------------");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            Console.WriteLine("Текст после удаления 'нн':");
            Console.WriteLine("-----------------");
            string resultText = File.ReadAllText(outputPath);
            Console.WriteLine(resultText);
            Console.WriteLine("-----------------");

            Console.WriteLine($"\nРезультат сохранён в файл: {outputPath}");

            Console.ReadKey();
        }
    }
}