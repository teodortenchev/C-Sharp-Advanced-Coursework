using System;
using System.IO;
using System.Linq;
namespace ReverseReadFile
{
    class ReverseReadFile
    {
        static void Main(string[] args)
        {
            string path = "../../../";
            string inputFileName = "ReverseReadFile.cs";
            string outputFileName = "reversed.txt";

            path = Path.Combine(path, inputFileName);

            using (StreamReader reader = new StreamReader(path))
            {

                using (StreamWriter writer = new StreamWriter(outputFileName))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine(String.Join("", line.Reverse()));

                        line = reader.ReadLine();
                    }
                }

                
            }
        }
    }
}
