using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task4.V30.Lib;

namespace Tyuiu.PyrkinAA.Sprint5.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            // Arrange
            DataService ds = new DataService();

            // Создаем временный файл
            string tempFile = Path.GetTempFileName();

            // Записываем тестовое значение (например, 2.5)
            File.WriteAllText(tempFile, "2.5");

            // Ожидаемое значение для x = 2.5
            double expected = 21.447; // (15.625 - (-0.747022)) + 5.075 = 21.447

            try
            {
                // Act
                double actual = ds.LoadFromDataFile(tempFile);

                // Assert
                Assert.AreEqual(expected, actual, 0.001, "Результат вычислений неверный!");
            }
            finally
            {
                // Очистка
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void ValidLoadFromDataFile_WithSpaces()
        {
            // Arrange
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "  1.5  "); // Число с пробелами

            double expected = -7.681; // Для x = 1.5

            try
            {
                // Act
                double actual = ds.LoadFromDataFile(tempFile);

                // Assert
                Assert.AreEqual(expected, actual, 0.001, "Не удалось обработать число с пробелами!");
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InvalidLoadFromDataFile_FileNotFound()
        {
            // Arrange
            DataService ds = new DataService();
            string fakePath = @"C:\FakeFolder\FakeFile.txt";

            // Act & Assert
            ds.LoadFromDataFile(fakePath);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void InvalidLoadFromDataFile_InvalidContent()
        {
            // Arrange
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "abc123"); // Не число

            try
            {
                // Act & Assert
                ds.LoadFromDataFile(tempFile);
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void InvalidLoadFromDataFile_EmptyFile()
        {
            // Arrange
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, ""); // Пустой файл

            try
            {
                // Act & Assert
                ds.LoadFromDataFile(tempFile);
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }
    }
}