using Tyuiu.PyrkinAA.Sprint5.Task7.V17.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

namespace Tyuiu.PyrkinAA.Sprint5.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();

            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V17.txt";

            
            Assert.IsTrue(File.Exists(inputPath), $"Файл {inputPath} не существует");

            string outputPath = ds.LoadDataAndSave(inputPath);

            
            Assert.IsTrue(File.Exists(outputPath), $"Выходной файл {outputPath} не создан");

            
            string resultText = File.ReadAllText(outputPath, Encoding.UTF8);

            
            string expectedText = "Пример текста без нн"; 
            Assert.AreEqual(expectedText, resultText);
        }

        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            Assert.AreEqual(true, res);
        }
    }
}
