using System;
using System.IO;

namespace P4CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string fileName = "copyMe.png";
            string outputFileName = "copiedYou.png";
            string filePath = Path.Combine("../../../../Files", fileName);
            string targetPath = Path.Combine("../../../../Files", outputFileName);

            using (FileStream source = new FileStream(filePath, FileMode.Open))
            {
                using (FileStream destination = new FileStream(targetPath, FileMode.Create))
                {
                    int bytesRead;
                    byte[] buffer = new byte[4096];

                    while ((bytesRead = source.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        destination.Write(buffer, 0, bytesRead);
                    }
                }
            }

        }
    }
}
