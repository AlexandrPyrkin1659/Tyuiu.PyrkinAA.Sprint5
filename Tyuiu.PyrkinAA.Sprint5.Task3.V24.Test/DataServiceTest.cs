using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists, "Файл не создан");

           
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                double valueFromFile = reader.ReadDouble();
                double expectedValue = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
                expectedValue = Math.Round(expectedValue, 3);

                Assert.AreEqual(expectedValue, valueFromFile, 0.001, "Значение в файле неверное");
            }

            
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}