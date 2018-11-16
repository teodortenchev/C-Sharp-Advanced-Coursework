using System;
using System.IO;
using System.Text;

namespace WritingTextToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"test
me
boy";

            FileStream file = new FileStream("log.txt", FileMode.Create);

            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                file.Write(bytes);

            }
            catch
            {
                Console.WriteLine("oops");
            }
            finally
            {
                file.Close();
            }
        }
    }
}
