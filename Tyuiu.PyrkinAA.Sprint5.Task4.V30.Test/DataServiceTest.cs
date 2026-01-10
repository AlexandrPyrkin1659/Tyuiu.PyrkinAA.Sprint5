using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PyrkinAA.Sprint5.Task4.V30.Lib;

namespace Tyuiu.PyrkinAA.Sprint5.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            
            DataService ds = new DataService();

            
            string tempFile = Path.GetTempFileName();

            
            File.WriteAllText(tempFile, "2.5");

          
            double expected = 21.447; 

            try
            {
             
                double actual = ds.LoadFromDataFile(tempFile);

                
                Assert.AreEqual(expected, actual, 0.001, "Результат вычислений неверный!");
            }
            finally
            {
                
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void ValidLoadFromDataFile_WithSpaces()
        {
           
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "  1.5  "); 

            double expected = -7.681; 

            try
            {
                
                double actual = ds.LoadFromDataFile(tempFile);

                
                Assert.AreEqual(expected, actual, 0.001, "Не удалось обработать число с пробелами!");
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InvalidLoadFromDataFile_FileNotFound()
        {
           
            DataService ds = new DataService();
            string fakePath = @"C:\FakeFolder\FakeFile.txt";

            ds.LoadFromDataFile(fakePath);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void InvalidLoadFromDataFile_InvalidContent()
        {
          
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "abc123"); 

            try
            {
                
                ds.LoadFromDataFile(tempFile);
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void InvalidLoadFromDataFile_EmptyFile()
        {
         
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, ""); 

            try
            {
               
                ds.LoadFromDataFile(tempFile);
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }
    }
}