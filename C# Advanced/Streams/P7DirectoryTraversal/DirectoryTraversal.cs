using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace P7DirectoryTraversal
{
    class DirectoryTraversal
    {
        static Dictionary<string, Dictionary<string, double>> directoryMap = new Dictionary<string, Dictionary<string, double>>();

        static void Main(string[] args)
        {
            string path = @"C:\Users\TeodorTenchev\source\repos\Streams\Files";

            TraverseDirectory(path);
            GenerateReport();


        }

        private static void GenerateReport()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            path = Path.Combine(path, "report.txt");


            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (var extension in directoryMap.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    streamWriter.WriteLine(extension.Key);

                    foreach (var file in extension.Value.OrderBy(x => x.Key))
                    {
                        streamWriter.WriteLine($"--{file.Key} - {file.Value}kb");
                    }
                }
            }


        }

        private static void TraverseDirectory(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] filesArray = directory.GetFiles();

            foreach (var item in filesArray)
            {
                //Console.WriteLine(Path.GetFileName(item.ToString()) + item.Length);
                //Console.WriteLine(Path.GetExtension(item.ToString()));
                string fullPath = item.ToString();
                string fileName = Path.GetFileName(fullPath);
                string fileExtension = Path.GetExtension(fullPath);

                double fileSize = item.Length / 1000d;

                if (!directoryMap.ContainsKey(fileExtension))
                {
                    directoryMap.Add(fileExtension, new Dictionary<string, double>());
                }

                directoryMap[fileExtension].Add(fileName, fileSize);




            }
        }
    }
}
