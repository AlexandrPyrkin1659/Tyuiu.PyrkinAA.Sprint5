using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;
namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveToFileTextData()
        {
            // Arrange
            DataService ds = new DataService();
            int x = 3;

            // Вычисляем ожидаемое значение
            double expectedValue = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            expectedValue = Math.Round(expectedValue, 3); // 169.890

            // Создаем байты для ожидаемого значения
            string expectedBase64;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            using (System.IO.BinaryWriter writer = new System.IO.BinaryWriter(ms))
            {
                writer.Write(expectedValue);
                expectedBase64 = Convert.ToBase64String(ms.ToArray());
            }

            // Act
            string result = ds.SaveToFileTextData(x);

            // Assert
            Assert.AreEqual(expectedBase64, result, "Base64 строки не совпадают!");
        }
    }
}