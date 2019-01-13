using System;
using System.Collections.Generic;
using System.Linq;

namespace P3GenericSwapMethodStrings
{
    class StartUp
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

            string[] swapIndexes = Console.ReadLine().Split();
            int index1 = int.Parse(swapIndexes[0]);
            int index2 = int.Parse(swapIndexes[1]);

            Swap(list, index1, index2);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Swap<T>(List<Box<T>> list, int index1, int index2)
        {
            Box<T> temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
