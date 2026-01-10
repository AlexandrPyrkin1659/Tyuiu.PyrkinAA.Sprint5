using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PyrkinAA.Sprint5.Task2.V14.Lib;
using System.IO;

namespace Tyuiu.PyrkinAA.Sprint5.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                {-3, -6, -3},
                {6, 8, 3},
                {-6, -5, 5}
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path), "Файл не был создан!");

            string[] fileLines = File.ReadAllLines(path);
            Assert.AreEqual(3, fileLines.Length, "Неверное количество строк в файле!");
            Assert.AreEqual("0;0;0", fileLines[0], "Неверная первая строка!");
            Assert.AreEqual("1;1;1", fileLines[1], "Неверная вторая строка!");
            Assert.AreEqual("0;0;1", fileLines[2], "Неверная третья строка!");

            File.Delete(path);
        }

        [TestMethod]
        public void CheckedArrayOfDifferentSize()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                {1, -2, 3, -4},
                {-5, 6, -7, 8}
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path), "Файл не был создан!");

            string[] fileLines = File.ReadAllLines(path);
            Assert.AreEqual(2, fileLines.Length, "Неверное количество строк!");
            Assert.AreEqual("1;0;1;0", fileLines[0], "Неверная первая строка!");
            Assert.AreEqual("0;1;0;1", fileLines[1], "Неверная вторая строка!");

            File.Delete(path);
        }
    }
}