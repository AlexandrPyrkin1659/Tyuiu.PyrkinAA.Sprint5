using Tyuiu.PyrkinAA.Sprint5.Task0.V3.Lib;
using System;

namespace Tyuiu.PyrkinAA.Sprint5.Task0.V3
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);

          
            string result = System.IO.File.ReadAllText(path);

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }
    }
}