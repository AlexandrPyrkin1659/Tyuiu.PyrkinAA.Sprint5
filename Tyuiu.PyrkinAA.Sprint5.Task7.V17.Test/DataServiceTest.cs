using Tyuiu.PyrkinAA.Sprint5.Task7.V17.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

namespace Tyuiu.PyrkinAA.Sprint5.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();

            // Используем реальный путь из параметра теста
            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V17.txt";

            // Если файла нет - создаём временный тестовый
            if (!File.Exists(inputPath))
            {
                inputPath = Path.GetTempFileName();
                File.WriteAllText(inputPath, "анна и джонн шли", Encoding.UTF8);
            }

            // Выполняем метод
            string outputPath = ds.LoadDataAndSave(inputPath);

            // Проверяем, что файл создан
            Assert.IsTrue(File.Exists(outputPath), "Выходной файл не создан");

            // Читаем результат
            string resultText = File.ReadAllText(outputPath, Encoding.UTF8);

            // Проверяем, что "нн" удалены
            Assert.IsFalse(resultText.Contains("нн"), "В результате остались 'нн'");
        }

        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";
            bool res = File.Exists(path);
            Assert.AreEqual(true, res);
        }
    }
}