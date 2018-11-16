using System;
using System.IO;

namespace P2LineNumbers
{
    class InsertLineNumbers
    {
        static void Main(string[] args)
        {
            string sourceFilePath = Path.Combine("../../../", "source.txt");
            string outputFilePath = Path.Combine("../../../", "output.txt");

            using (StreamReader streamReader = new StreamReader(sourceFilePath, System.Text.Encoding.UTF8))
            {
                using (StreamWriter streamWriter = new StreamWriter(outputFilePath))
                {
                    string line;
                    int counter = 0;

                    while ((line = streamReader.ReadLine()) != null)
                     {
                        streamWriter.WriteLine($"Line {++counter}: {line}");
                    }
                }
            }

        }
    }
}
