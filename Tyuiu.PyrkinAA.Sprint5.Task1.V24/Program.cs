using Tyuiu.PyrkinAA.Sprint5.Task1.V24.Lib;
namespace Tyuiu.PyrkinAA.Sprint5.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"startValue = {startValue}");
            Console.WriteLine($"stopValue = {stopValue}");
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");

            Console.WriteLine();
            Console.WriteLine("Таблица значений функции F(x) = (3*cos(x))/(4*x-0.5) + sin(x) - 5*x - 2:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|    x    |    f(x)    |");
            Console.WriteLine("-----------------------------");

            
            string[] lines = File.ReadAllLines(path);
            int x = startValue;

            foreach (string line in lines)
            {
                double y = double.Parse(line);
                Console.WriteLine($"| {x,6}  | {y,10:F2} |");
                x++;
            }

            Console.WriteLine("-----------------------------");

            Console.ReadKey();
        }
    }
}