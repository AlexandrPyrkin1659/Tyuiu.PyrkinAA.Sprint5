using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.PyrkinAA.Sprint5.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;
            string base64Result = ds.SaveToFileTextData(x);

           
            string expectedBase64 = "FK5H4Xo8ZUA=";
            Assert.AreEqual(expectedBase64, base64Result);

            
            byte[] bytes = Convert.FromBase64String(base64Result);
            double value = BitConverter.ToDouble(bytes, 0);
            double expectedValue = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
            expectedValue = Math.Round(expectedValue, 3);

            Assert.AreEqual(expectedValue, value, 0.001);
        }
    }
}