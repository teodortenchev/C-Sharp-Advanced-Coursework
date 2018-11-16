using System;
using System.IO;

namespace P1OddLines
{
    class PrintOddLinesFromTextFile
    {
        static void Main(string[] args)
        {
            
            string fileName = "sample.txt";
            string filePath = Path.Combine("../../../", fileName);
            //string outputFile = "sample-odd-lines.txt";
            //string targetPath = Path.Combine("../../../", outputFile);

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                int counter = 0;

                while (true)
                {
                    string line = streamReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (counter %2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                }
            }
        }
    }
}
