using Tyuiu.PyrkinAA.Sprint5.Task3.V24.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            string result = ds.SaveToFileTextData(x);

            string expected = "FK5H4Xo8ZUA=";

            Assert.AreEqual(expected, result);
        }
    }
}
}