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

        
            double wait = 4.100; 
            Assert.AreEqual(wait, result);
        }
    }
}