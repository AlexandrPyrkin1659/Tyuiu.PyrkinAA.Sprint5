using Tyuiu.PyrkinAA.Sprint5.Task1.V24.Lib;
namespace Tyuiu.PyrkinAA.Sprint5.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

          
            string path = ds.SaveToFileTextData(startValue, stopValue);

            
            Assert.IsTrue(File.Exists(path), "Файл не создан!");

            
            string[] fileLines = File.ReadAllLines(path);
            Assert.AreEqual(11, fileLines.Length, "Неверное количество строк в файле!");

            
            double expectedFirst = Math.Round((3 * Math.Cos(-5)) / (4 * (-5) - 0.5) + Math.Sin(-5) - 5 * (-5) - 2, 2);
            double actualFirst = double.Parse(fileLines[0]);
            Assert.AreEqual(expectedFirst, actualFirst, 0.01, "Неверное значение для x = -5!");

           
            double expectedForZero = Math.Round((3 * Math.Cos(0)) / (4 * 0 - 0.5) + Math.Sin(0) - 5 * 0 - 2, 2);
            double actualForZero = double.Parse(fileLines[5]); 
            Assert.AreEqual(expectedForZero, actualForZero, 0.01, "Неверное значение для x = 0!");

           
            double expectedLast = Math.Round((3 * Math.Cos(5)) / (4 * 5 - 0.5) + Math.Sin(5) - 5 * 5 - 2, 2);
            double actualLast = double.Parse(fileLines[10]);
            Assert.AreEqual(expectedLast, actualLast, 0.01, "Неверное значение для x = 5!");

            
            File.Delete(path);
        }
    }
}
