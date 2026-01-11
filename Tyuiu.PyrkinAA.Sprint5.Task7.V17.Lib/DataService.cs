using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task7.V17.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path)
        {
            
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V17.txt");

           
            string text = File.ReadAllText(path, Encoding.UTF8);

            
            string resultText = text.Replace("нн", "");

          
            File.WriteAllText(outputPath, resultText, Encoding.UTF8);

            return outputPath;
        }
    }
}