using Tyuiu.PyrkinAA.Sprint5.Task1.V24.Lib;
namespace Tyuiu.PyrkinAA.Sprint5.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона:  {stopValue}");
            Console.WriteLine($"Шаг: 1");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            DataService ds = new DataService();

            
            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");
            Console.WriteLine();

           
            Console.WriteLine("Таблица значений функции F(x):");
            Console.WriteLine("------------------------------");
            Console.WriteLine("|    x    |     F(x)     |");
            Console.WriteLine("------------------------------");

            try
            {
                string[] results = File.ReadAllLines(path);
                int x = startValue;

                foreach (string line in results)
                {
                    double y = double.Parse(line);
                    Console.WriteLine($"| {x,6}  | {y,12:F2} |");
                    x++;
                }

                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.WriteLine($"Результаты сохранены в файл:");
                Console.WriteLine($"{Path.GetFullPath(path)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Для продолжения нажмите любую клавишу...                                *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}