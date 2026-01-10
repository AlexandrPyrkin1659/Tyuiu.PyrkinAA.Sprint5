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
            string path = ds.SaveToFileTextData(x);

            
            double result;
            using (System.IO.BinaryReader reader = new System.IO.BinaryReader(System.IO.File.Open(path, System.IO.FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Результат: " + result.ToString("F3"));

            Console.ReadKey();
        }
    }
}
