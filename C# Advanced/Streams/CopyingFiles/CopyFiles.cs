using System;
using System.IO;

namespace CopyingFiles
{
    class CopyFiles
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\TeodorTenchev\Desktop\azirevpn-us1.conf";
            string destinationPath = @"C:\Users\TeodorTenchev\Music\azirevpn-us1-copy.conf";

            FileStream sourceFile = new FileStream(filePath, FileMode.Open);

            using (sourceFile)
            { 
                FileStream destination = new FileStream(destinationPath, FileMode.Create);
                
                using(destination)
                {
                    while(true)
                    {
                        byte[] buffer = new byte[4096];
                        int readBytes = sourceFile.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
