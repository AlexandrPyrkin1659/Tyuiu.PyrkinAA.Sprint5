using Tyuiu.PyrkinAA.Sprint5.Task6.V17.Lib;
using System;

namespace Tyuiu.PyrkinAA.Sprint5.Task6.V17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";
            Console.WriteLine("Путь: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int result = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество пробелов, идущих подряд больше одного: " + result);
            Console.ReadKey();
        }
    }
}