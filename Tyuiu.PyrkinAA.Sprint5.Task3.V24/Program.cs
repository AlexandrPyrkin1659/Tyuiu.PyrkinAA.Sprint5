using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;
using System;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Пыркин А. А. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнил: Пыркин Александр Артемьевич | АСОиУб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение F(x) = 6.1x³ + 0.23x² + 1.04x, вычислить его значение    *");
        Console.WriteLine("* при x = 3, результат сохранить в бинарный файл OutPutFileTask3.bin      *");
        Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"Выражение: F(x) = 6.1*{x}³ + 0.23*{x}² + 1.04*{x}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string path = ds.SaveToFileTextData(x);

        
        double result = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
        result = Math.Round(result, 3);

        Console.WriteLine($"Результат вычисления: {result}");
        Console.WriteLine($"Файл: {path}");
        Console.WriteLine("Создан");

        Console.ReadKey();
    }
}