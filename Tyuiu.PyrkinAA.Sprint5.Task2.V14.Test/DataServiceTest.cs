using Tyuiu.PyrkinAA.Sprint5.Task2.V14.Lib;
using System.IO;
namespace Tyuiu.PyrkinAA.Sprint5.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
         
            DataService ds = new DataService();

       
            int[,] matrix = {
                {-3, -6, -3},
                {6, 8, 3},
                {-6, -5, 5}
            };

        
            string path = ds.SaveToFileTextData(matrix);

          
            Assert.IsTrue(File.Exists(path), "Файл не был создан!");

           
            string[] fileLines = File.ReadAllLines(path);

      
            Assert.AreEqual(3, fileLines.Length, "Неверное количество строк в файле!");

         
            Assert.AreEqual("0;0;0", fileLines[0], "Неверная первая строка!");

       
            Assert.AreEqual("1;1;1", fileLines[1], "Неверная вторая строка!");

         
            Assert.AreEqual("0;0;1", fileLines[2], "Неверная третья строка!");

           
            File.Delete(path);
        }

        [TestMethod]
        public void CheckedEmptyArray()
        {
        
            DataService ds = new DataService();
            int[,] emptyMatrix = new int[0, 0]; 

          
            string path = ds.SaveToFileTextData(emptyMatrix);

            Assert.IsTrue(File.Exists(path), "Файл не был создан для пустого массива!");

            string[] fileLines = File.ReadAllLines(path);
            Assert.AreEqual(0, fileLines.Length, "Файл должен быть пустым для пустого массива!");

        
            File.Delete(path);
        }

        [TestMethod]
        public void CheckedAllPositive()
        {
        
            DataService ds = new DataService();
            int[,] positiveMatrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            
            string path = ds.SaveToFileTextData(positiveMatrix);

       
            Assert.IsTrue(File.Exists(path), "Файл не был создан!");

            string[] fileLines = File.ReadAllLines(path);
            Assert.AreEqual(3, fileLines.Length, "Неверное количество строк!");

            
            foreach (string line in fileLines)
            {
                Assert.AreEqual("1;1;1", line, "Для положительных элементов должна быть строка '1;1;1'!");
            }


            File.Delete(path);
        }

        [TestMethod]
        public void CheckedAllNegative()
        {
         
            DataService ds = new DataService();
            int[,] negativeMatrix = {
                {-1, -2, -3},
                {-4, -5, -6},
                {-7, -8, -9}
            };

         
            string path = ds.SaveToFileTextData(negativeMatrix);

       
            Assert.IsTrue(File.Exists(path), "Файл не был создан!");

            string[] fileLines = File.ReadAllLines(path);
            Assert.AreEqual(3, fileLines.Length, "Неверное количество строк!");


            foreach (string line in fileLines)
            {
                Assert.AreEqual("0;0;0", line, "Для отрицательных элементов должна быть строка '0;0;0'!");
            }

            
            File.Delete(path);
        }
    }
}
