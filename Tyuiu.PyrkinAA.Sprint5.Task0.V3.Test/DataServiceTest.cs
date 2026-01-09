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

       
            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);

        
            string expected = "-1";
            string actual = File.ReadAllText(path);
            Assert.AreEqual(expected, actual);
        }
    }
}
