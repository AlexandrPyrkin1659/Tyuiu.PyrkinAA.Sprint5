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

           
            string path = ds.SaveToFileTextData(-5, 5);

          
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists, "Файл не был создан!");

            
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        [TestMethod]
        public void CheckedValuesInFile()
        {
            
            DataService ds = new DataService();

           
            string path = ds.SaveToFileTextData(-5, 5);

           
            string[] lines = File.ReadAllLines(path);
            Assert.IsTrue(lines.Length > 0, "Файл пустой!");

            
            Assert.AreEqual(11, lines.Length, "Неверное количество строк!");

            
            foreach (string line in lines)
            {
                bool canParse = double.TryParse(line, out _);
                Assert.IsTrue(canParse, $"Не могу преобразовать '{line}' в число!");
            }

            
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}

