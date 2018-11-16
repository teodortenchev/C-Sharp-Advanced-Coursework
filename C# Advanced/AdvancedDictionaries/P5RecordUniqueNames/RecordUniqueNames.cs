using System;
using System.Collections.Generic;

namespace P5RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int numberOfNames = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < numberOfNames; i++)
            {
                string name = Console.ReadLine();
                uniqueNames.Add(name);
            }
           
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
