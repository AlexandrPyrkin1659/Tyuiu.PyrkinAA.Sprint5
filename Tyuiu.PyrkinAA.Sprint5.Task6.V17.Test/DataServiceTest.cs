using Tyuiu.PyrkinAA.Sprint5.Task6.V17.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.PyrkinAA.Sprint5.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
           
            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";
            string testText = "Hello  world   !"; 
            File.WriteAllText(path, testText);

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

           
            int expected = 5; 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            Assert.AreEqual(true, res);
        }
    }
}