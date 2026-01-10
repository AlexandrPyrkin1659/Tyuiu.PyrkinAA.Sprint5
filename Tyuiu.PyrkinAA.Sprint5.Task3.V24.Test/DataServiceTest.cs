using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveToFileTextData()
        {
       
            DataService ds = new DataService();
            int x = 3;

           
            double expected = 6.1 * 27 + 0.23 * 9 + 1.04 * 3;
            expected = Math.Round(expected, 3); 
        
            string filePath = ds.SaveToFileTextData(x);

          
            Assert.IsTrue(File.Exists(filePath), $"Файл не создан по пути: {filePath}");

           
            double actual;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                actual = reader.ReadDouble();
            }

       
            Assert.AreEqual(expected, actual, 0.0001, "Значение в файле не совпадает с ожидаемым");

           
            Assert.AreEqual(169.890, actual, 0.0001, "Округление выполнено некорректно");
        }
    }
}