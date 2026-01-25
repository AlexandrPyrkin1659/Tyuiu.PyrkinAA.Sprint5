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
        Console.WriteLine("* Дано выражение, вычислить его значение при x = 3, результат сохранить в *");
        Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до    *");
        Console.WriteLine("* трёх знаков после запятой.                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;
        Console.WriteLine($"x = {x}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string path = ds.SaveToFileTextData(x);

        
        double result = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
        result = Math.Round(result, 3);

        Console.WriteLine($"Результат вычисления: {result}");
        Console.WriteLine($"Файл сохранен: {path}");
        Console.WriteLine("Создан");

        Console.ReadKey();
    }
}
