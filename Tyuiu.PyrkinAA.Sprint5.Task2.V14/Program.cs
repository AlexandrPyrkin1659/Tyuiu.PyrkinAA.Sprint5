using System;
using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task2.V14.Lib;

namespace Tyuiu.PyrkinAA.Sprint5.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Пыркин А.А. | АСОиУб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Пыркин А.А. | АСОиУб-23-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv      *");
            Console.WriteLine("* и вывести на консоль.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

           
            int[,] array = {
                {-3, -6, -3},
                {6, 8, 3},
                {-6, -5, 5}
            };

            Console.WriteLine("Исходный массив 3x3:");
            Console.WriteLine("-------------------");
            PrintArray(array);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            DataService ds = new DataService();

            
            string path = ds.SaveToFileTextData(array);

            Console.WriteLine($"Файл сохранен по пути: {path}");
            Console.WriteLine();

           
            Console.WriteLine("Преобразованный массив (положительные → 1, отрицательные → 0):");
            Console.WriteLine("---------------------------------------------------------------");

           
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[,] transformedArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transformedArray[i, j] = array[i, j] > 0 ? 1 : 0;
                }
            }

            PrintArray(transformedArray);

            Console.WriteLine();
            Console.WriteLine("Содержимое файла OutPutFileTask2.csv:");
            Console.WriteLine("-------------------------------------");

           
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Файл не найден!");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Для продолжения нажмите любую клавишу...                                *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }

        
        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}