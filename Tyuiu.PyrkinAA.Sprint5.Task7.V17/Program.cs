using Tyuiu.PyrkinAA.Sprint5.Task7.V17.Lib;
using System;
using System.IO;

namespace Tyuiu.PyrkinAA.Sprint5.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V17.txt";

            if (!File.Exists(inputPath))
            {
                Console.WriteLine("Файл не найден!");
                return;
            }

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            Console.WriteLine($"Результат сохранён в: {outputPath}");

            if (File.Exists(outputPath))
            {
                Console.WriteLine("\nРезультат:");
                Console.WriteLine(File.ReadAllText(outputPath));
            }

            Console.ReadKey();
        }
    }
}