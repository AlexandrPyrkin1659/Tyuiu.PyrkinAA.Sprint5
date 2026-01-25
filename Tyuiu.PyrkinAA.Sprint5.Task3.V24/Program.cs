using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;
using System;
using System.IO;

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
        Console.WriteLine("* Дано выражение y = x³ + 2x² + 5x + 4, вычислить его значение при x = 3, *");
        Console.WriteLine("* результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на    *");
        Console.WriteLine("* консоль. Округлить до трёх знаков после запятой.                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;
        Console.WriteLine($"x = {x}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        
        string base64Result = ds.SaveToFileTextData(x);

        
        byte[] bytes = Convert.FromBase64String(base64Result);
        double result = BitConverter.ToDouble(bytes, 0);

        Console.WriteLine($"Результат вычисления: {result}");
        Console.WriteLine($"Base64 представление: {base64Result}");

        
        string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
        Console.WriteLine($"Файл сохранен: {filePath}");

        Console.ReadKey();
    }
}