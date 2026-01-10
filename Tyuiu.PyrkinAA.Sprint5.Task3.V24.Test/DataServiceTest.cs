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

         
            double expected = 67 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            expected = Math.Round(expected, 3);

       
            string path = ds.SaveToFileTextData(x);

          
            Assert.IsTrue(File.Exists(path), "Файл не создан!");

            
            double actual;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                actual = reader.ReadDouble();
            }

        
            Assert.AreEqual(expected, actual, 0.001, "Значения не совпадают!");

           
            string actualString = actual.ToString("F3");
            string expectedString = expected.ToString("F3");
            Assert.AreEqual(expectedString, actualString, "Округление некорректно!");
        }
    }
}