namespace P4GenericSwapMethodIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> list = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                list.Add(new Box<int>(int.Parse(value)));
            }

            int[] swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index1 = swapIndexes[0];
            int index2 = swapIndexes[1];

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
