using System;
using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string base64Result = ds.SaveToFileTextData(x);


            byte[] bytes = Convert.FromBase64String(base64Result);
            double result;
            using (MemoryStream ms = new MemoryStream(bytes))
            using (BinaryReader reader = new BinaryReader(ms))
            {
                result = reader.ReadDouble();
            }

            Console.WriteLine("Результат: " + result.ToString("F3"));
            Console.WriteLine("Base64: " + base64Result);

            Console.ReadKey();
        }
    }
}
