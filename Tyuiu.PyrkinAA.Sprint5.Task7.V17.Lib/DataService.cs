using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task7.V17.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path)
        {
            // Создаём путь для выходного файла рядом с входным
            string outputPath = Path.Combine(Path.GetDirectoryName(path), "OutPutDataFileTask7V17.txt");

            // Читаем исходный файл
            string text = File.ReadAllText(path, Encoding.UTF8);

            // Удаляем все вхождения "нн"
            string resultText = text.Replace("нн", "");

            // Сохраняем результат
            File.WriteAllText(outputPath, resultText, Encoding.UTF8);

            return outputPath;
        }
    }
}
