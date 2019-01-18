using System;
using System.Linq;

namespace P01_ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] createParams = Console.ReadLine().Split().Skip(1).ToArray();

            ListyIterator<string> listyIterator = new ListyIterator<string>();
            listyIterator.Create(createParams);

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }

                else if (command == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }

                else
                {
                    Console.WriteLine("Command is not recognized.");
                }

                command = Console.ReadLine();
            }

        }
    }
}
