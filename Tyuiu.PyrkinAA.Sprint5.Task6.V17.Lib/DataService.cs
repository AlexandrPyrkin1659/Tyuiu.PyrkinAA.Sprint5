using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyrkinAA.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int count = 0;
            int spaceSequenceLength = 0;

            foreach (char c in text)
            {
                if (c == ' ')
                {
                    spaceSequenceLength++;
                }
                else
                {
                    if (spaceSequenceLength > 1)
                    {
                        count += spaceSequenceLength; 
                        
                    }
                    spaceSequenceLength = 0;
                }
            }

            
            if (spaceSequenceLength > 1)
            {
                count += spaceSequenceLength; 
            }

            return count;
        }
    }
}