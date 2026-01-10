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
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Пыркин Алексей Андреевич | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл InPutDataFileTask4V30.txt. Прочитать значение из файла и      *");
            Console.WriteLine("* подставить в формулу: y = (x³ - tg(x)) + 2.03x                         *");
            Console.WriteLine("* Вычислить и вывести результат на консоль. Округлить до 3 знаков.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

          
            string path = "/app/data/AssesmentData/C#/Sprint5Task4/InPutDataFileTask4V30.txt";

            
            string localPath = @"C:\DataSprint5\InPutDataFileTask4V30.txt";

            Console.WriteLine($"Основной путь к файлу: {path}");
            Console.WriteLine($"Локальный путь: {localPath}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            try
            {
                
                double result;
                if (File.Exists(path))
                {
                    Console.WriteLine($"Используется основной путь: {path}");
                    result = ds.LoadFromDataFile(path);
                }
                else if (File.Exists(localPath))
                {
                    Console.WriteLine($"Используется локальный путь: {localPath}");
                    result = ds.LoadFromDataFile(localPath);
                }
                else
                {
                    Console.WriteLine("Файл не найден ни по одному из путей!");
                    Console.WriteLine("Создайте папку C:\\DataSprint5\\ и скопируйте туда файл.");
                    Console.ReadKey();
                    return;
                }

                
                Console.WriteLine($"Результат вычислений: {result:F3}");


                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ДОПОЛНИТЕЛЬНАЯ ИНФОРМАЦИЯ:                                              *");
                Console.WriteLine("***************************************************************************");

              
                string usedPath = File.Exists(path) ? path : localPath;
                string fileContent = File.ReadAllText(usedPath);
                Console.WriteLine($"Содержимое файла: '{fileContent}'");

                
                double x = double.Parse(fileContent.Trim());
                Console.WriteLine($"Значение x: {x}");
                Console.WriteLine($"x³ = {Math.Pow(x, 3):F3}");
                Console.WriteLine($"tg(x) = {Math.Tan(x):F3}");
                Console.WriteLine($"2.03x = {2.03 * x:F3}");
                Console.WriteLine($"Итоговая формула: ({Math.Pow(x, 3):F3} - {Math.Tan(x):F3}) + {2.03 * x:F3}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"ОШИБКА: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"ОШИБКА ФОРМАТА: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"НЕИЗВЕСТНАЯ ОШИБКА: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}