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

      
            Assert.IsTrue(File.Exists(path), $"Файл не найден: {path}");

            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual(3, lines.Length);
            Assert.AreEqual("0;0;0", lines[0]);
            Assert.AreEqual("1;1;1", lines[1]);
            Assert.AreEqual("0;0;1", lines[2]);

            
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}