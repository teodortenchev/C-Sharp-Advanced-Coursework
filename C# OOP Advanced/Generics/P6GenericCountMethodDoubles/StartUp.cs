namespace P6GenericCountMethodDoubles
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> list = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                double value = double.Parse(Console.ReadLine());
                list.Add(new Box<double>(value));
            }

            string element = Console.ReadLine();

            Console.WriteLine(CountGreater<double>(list, double.Parse(element)));


        }

        static int CountGreater<T>(IEnumerable<Box<T>> collection, T element)
              where T : IComparable<T>
        {
            int result = 0;

            foreach (var item in collection)
            {
                if (item.CompareTo(element) > 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
