
namespace P5GenericCountMethodStrings
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                list.Add(new Box<string>(value));
            }

            string element = Console.ReadLine();

            Console.WriteLine(CountGreater<string>(list, element));


        }

      static int CountGreater<T>(IEnumerable<Box<T>> collection, T element)
            where T : IComparable<T>
        {
            int result = 0;

            foreach (var item in collection)
            {
                if(item.CompareTo(element) > 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
