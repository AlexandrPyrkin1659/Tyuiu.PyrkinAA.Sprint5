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

          
            if (!File.Exists(inputPath))
            {
                inputPath = Path.GetTempFileName();
                File.WriteAllText(inputPath, "анна и джонн шли", Encoding.UTF8);
            }

           
            string outputPath = ds.LoadDataAndSave(inputPath);

            
            Assert.IsTrue(File.Exists(outputPath), "Выходной файл не создан");

      
            string resultText = File.ReadAllText(outputPath, Encoding.UTF8);

           
            Assert.IsFalse(resultText.Contains("нн"), "В результате остались 'нн'");
        }

        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";
            bool res = File.Exists(path);
            Assert.AreEqual(true, res);
        }
    }
}