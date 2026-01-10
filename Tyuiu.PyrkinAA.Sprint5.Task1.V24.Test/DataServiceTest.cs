using Tyuiu.PyrkinAA.Sprint5.Task1.V24.Lib;
namespace Tyuiu.PyrkinAA.Sprint5.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            
            string path = ds.SaveToFileTextData(startValue, stopValue);

            
            Assert.IsTrue(File.Exists(path), "Файл не был создан!");

            
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        [TestMethod]
        public void CheckedFileContent()
        {
           
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            
            string path = ds.SaveToFileTextData(startValue, stopValue);
            string[] fileLines = File.ReadAllLines(path);

            
            Assert.AreEqual(11, fileLines.Length, "Неверное количество строк!");

           
            double expected1 = Math.Round((3 * Math.Cos(-5)) / (4 * (-5) - 0.5) + Math.Sin(-5) - 5 * (-5) - 2, 2);
            double actual1 = double.Parse(fileLines[0]);
            Assert.AreEqual(expected1, actual1, 0.01, "Неверное значение для x = -5");

            
            double expected2 = Math.Round((3 * Math.Cos(0)) / (4 * 0 - 0.5) + Math.Sin(0) - 5 * 0 - 2, 2);
            double actual2 = double.Parse(fileLines[5]); 
            Assert.AreEqual(expected2, actual2, 0.01, "Неверное значение для x = 0");

          
            double expected3 = Math.Round((3 * Math.Cos(5)) / (4 * 5 - 0.5) + Math.Sin(5) - 5 * 5 - 2, 2);
            double actual3 = double.Parse(fileLines[10]);
            Assert.AreEqual(expected3, actual3, 0.01, "Неверное значение для x = 5");

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}

