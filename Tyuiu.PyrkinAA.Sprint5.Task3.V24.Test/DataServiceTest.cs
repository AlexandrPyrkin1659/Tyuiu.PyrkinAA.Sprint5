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

            // Ожидаемое значение в Base64
            string expectedBase64 = "FK5H4Xo8ZUA=";

            // Act
            string result = ds.SaveToFileTextData(x);

            // Assert
            Assert.AreEqual(expectedBase64, result, "Base64 строки не совпадают!");

            // Дополнительная проверка - декодируем и проверяем значение
            byte[] bytes = Convert.FromBase64String(result);
            double value = BitConverter.ToDouble(bytes, 0);
            Assert.AreEqual(1814.190, value, 0.0001, "Значение double не совпадает!");
        }
    }
}