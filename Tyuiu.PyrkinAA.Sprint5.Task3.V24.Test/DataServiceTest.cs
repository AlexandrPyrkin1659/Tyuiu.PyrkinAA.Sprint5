using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

         
            double expectedValue = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            expectedValue = Math.Round(expectedValue, 3); 

     
            string expectedBase64;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            using (System.IO.BinaryWriter writer = new System.IO.BinaryWriter(ms))
            {
                writer.Write(expectedValue);
                expectedBase64 = Convert.ToBase64String(ms.ToArray());
            }

        
            string result = ds.SaveToFileTextData(x);

     
            Assert.AreEqual(expectedBase64, result, "Base64 строки не совпадают!");
        }
    }
}