using System;
using System.IO;

namespace Streams
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            string path = "../../../";
            string fileName = "ReadFile.cs";

            path = Path.Combine(path, fileName);

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                int count = 0;
                while (line != null)
                {
                    Console.WriteLine($"Line {++count}: {line}");
                    line = reader.ReadLine();
                }
            }

            
        }
    }
}
