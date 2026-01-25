using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int x = 3;

            string path = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);

           
            if (fileExists)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    double valueFromFile = reader.ReadDouble();
                    double expectedValue = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
                    expectedValue = Math.Round(expectedValue, 3);

                    Assert.AreEqual(expectedValue, valueFromFile, 0.001);
                }

                
                File.Delete(path);
            }
        }
    }
}