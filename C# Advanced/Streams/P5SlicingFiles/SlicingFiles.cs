using System;
using System.Collections.Generic;
using System.IO;

namespace P5SlicingFiles
{
    class SlicingFiles
    {
        static List<string> paths = new List<string>();

        static void Main(string[] args)
        {
            string sourceFile = Path.Combine("../../../../Files", "sliceMe.mp4");
            string destination = "../../../../Files/Sliced/";
            int parts = 5;

            Slice(sourceFile, destination, parts);
            Assemble(paths, destination);

        }


        private static void Slice(string sourceFile, string destination, int parts)
        {
            FileStream readFile = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
            long size = (readFile.Length / parts);
            byte[] buffer = new byte[size];
            


            for (int i = 0; i < parts; i++)
            {
                paths.Add(destination + $"Part{i}.mp4");

                FileStream writeFile = new FileStream(paths[i], FileMode.Create, FileAccess.Write);
                int byteCount = readFile.Read(buffer, 0, buffer.Length);
                writeFile.Write(buffer, 0, buffer.Length);
                writeFile.Flush();
                writeFile.Close();
            }
            readFile.Close();
            


        }
        private static void Assemble(List<string> paths, string destination)
        {
            byte[] buffer;

            FileStream writeFile = new FileStream(destination + "combined.mp4", FileMode.Append, FileAccess.Write);
            

            if (writeFile.CanWrite)
            {
                foreach (var path in paths)
                {

                    while (true)
                    {
                        FileStream readFile = new FileStream(path, FileMode.Open, FileAccess.Read);
                        buffer = new byte[readFile.Length];
                        int byteCount = readFile.Read(buffer, 0, buffer.Length);
                        if (byteCount == 0)
                        {
                            readFile.Close();
                            break;
                        }
                        writeFile.Write(buffer, 0, buffer.Length);
                        readFile.Close();
                    }
                }
            }

            writeFile.Flush();
            writeFile.Close();
            
        }
    }
}
