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

            // Создаем временный файл с тестовыми данными
            string tempFile = Path.GetTempFileName();

            // Записываем тестовое значение в файл (например, 1.5)
            File.WriteAllText(tempFile, "1.5");

            // Ожидаемое значение для x = 1.5:
            // x³ = 1.5³ = 3.375
            // tg(1.5) ≈ 14.1014
            // (3.375 - 14.1014) + 2.03*1.5 = (-10.7264) + 3.045 = -7.6814
            // Округление до 3 знаков: -7.681
            double expected = -7.681;

            try
            {
                // Act
                double actual = ds.LoadFromDataFile(tempFile);

                // Assert
                Assert.AreEqual(expected, actual, 0.001, "Значения не совпадают!");
            }
            finally
            {
                // Удаляем временный файл
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void ValidLoadFromDataFile_WithDifferentValue()
        {
            // Arrange
            DataService ds = new DataService();

            // Создаем временный файл с другим значением
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "2.0");

            // Ожидаемое значение для x = 2.0:
            // x³ = 8
            // tg(2.0) ≈ -2.1850
            // (8 - (-2.1850)) + 2.03*2 = (8 + 2.1850) + 4.06 = 10.185 + 4.06 = 14.245
            // Округление до 3 знаков: 14.245
            double expected = 14.245;

            try
            {
                // Act
                double actual = ds.LoadFromDataFile(tempFile);

                // Assert
                Assert.AreEqual(expected, actual, 0.001, "Значения не совпадают!");
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
            string nonExistentFile = @"C:\NonExistentFolder\NonExistentFile.txt";

            // Act & Assert
            ds.LoadFromDataFile(nonExistentFile);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void InvalidLoadFromDataFile_InvalidFormat()
        {
            // Arrange
            DataService ds = new DataService();

            // Создаем временный файл с некорректными данными
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "не число");

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