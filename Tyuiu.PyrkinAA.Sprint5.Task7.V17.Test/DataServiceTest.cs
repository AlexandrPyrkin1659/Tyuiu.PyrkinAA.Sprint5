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

            // Создаём тестовый файл во временной директории
            string testDir = Path.GetTempPath();
            string testInputPath = Path.Combine(testDir, "InPutDataFileTask7V17.txt");

            // Пишем тестовое содержимое
            string testText = "анна и джонн шли по ннной дороге";
            File.WriteAllText(testInputPath, testText, Encoding.UTF8);

            // Выполняем метод
            string outputPath = ds.LoadDataAndSave(testInputPath);

            // Проверяем, что файл создан
            Assert.IsTrue(File.Exists(outputPath), "Выходной файл не создан");

            // Читаем результат
            string resultText = File.ReadAllText(outputPath, Encoding.UTF8);
            string expectedText = "аа и джон шли по ной дороге";

            // Проверяем корректность замены
            Assert.AreEqual(expectedText, resultText);

            // Удаляем временные файлы
            File.Delete(testInputPath);
            File.Delete(outputPath);
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
