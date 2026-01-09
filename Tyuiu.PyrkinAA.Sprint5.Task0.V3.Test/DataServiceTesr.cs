using Tyuiu.PyrkinAA.Sprint5.Task0.V3.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.PyrkinAA.Sprint5.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
         
            DataService ds = new DataService();
            int x = 3;

          
            string path = ds.SaveToFileTextData(x);


            Assert.IsTrue(File.Exists(path), $"Файл не создан по пути: {path}");

         
            string content = File.ReadAllText(path).Trim();
            Assert.AreEqual("-1", content, $"Ожидалось '-1', получено '{content}'");

  
            File.Delete(path);
        }

    }
}