using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task5.V6.Lib;


namespace Tyuiu.PyrkinAA.Sprint5.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V6.txt";

            Assert.IsTrue(File.Exists(path), $"Файл {path} не существует");

            double result = ds.LoadFromDataFile(path);

            // Для примера: если в файле числа 1.5, 2.3, 3.2, 5.1, 8.4
            // sum = 1.5 + 2.3 + 3.2 + 5.1 + 8.4 = 20.5
            // count = 5
            // average = 20.5 / 5 = 4.1
            // Округление: 4.100
            double wait = 4.100; // Замените на фактическое ожидаемое значение
            Assert.AreEqual(wait, result);
        }
    }
}