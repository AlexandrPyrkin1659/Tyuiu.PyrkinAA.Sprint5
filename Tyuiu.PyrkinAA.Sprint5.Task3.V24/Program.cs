using System;
using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine("Значение X:" + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                             **");
            Console.WriteLine("***************************************************************************");
            string result = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + result);
            Console.ReadKey();
        }
    }
}

