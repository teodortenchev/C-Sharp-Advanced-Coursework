using System;
using System.Text;
using System.IO;
namespace ReadingInMemoryString
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "Test#@@#.dat";
            //Create random data to write to file.
            byte[] dataArray = new byte[100000];
            new Random().NextBytes(dataArray);

            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                for (int i = 0; i < dataArray.Length; i++)
                {
                    fileStream.WriteByte(dataArray[i]);
                }
                // Set the stream position to the beginning of the file.
                fileStream.Seek(0, SeekOrigin.Begin);

                //Read and verity the data.

                for (int i = 0; i < fileStream.Length; i++)
                {
                    if (dataArray[i] != fileStream.ReadByte())
                    {
                        Console.WriteLine("Error writing data.");
                        return;
                    }
                }

                Console.WriteLine("The data was written to {0} " + "and verified.", fileStream.Name);
            }

        }
    }
}
