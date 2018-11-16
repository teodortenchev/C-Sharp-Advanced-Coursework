using System;
using System.Collections.Generic;

namespace P3ProductShop
{
    class ProductShop
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Revision")
            {
                if (!shops.ContainsKey(input[0]))
                {
                    shops.Add(input[0], new Dictionary<string, double>());
                }
                if (!shops[input[0]].ContainsKey(input[1]))
                {
                    shops[input[0]].Add(input[1], 0);
                }

                shops[input[0]][input[1]] = Double.Parse(input[2]);

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var shop in shops)
            {
                string storeName = shop.Key;

                Console.WriteLine($"{storeName}->");
                foreach (var item in shop.Value)
                {
                    string product = item.Key;
                    double value = item.Value;
                    Console.WriteLine($"Product: {product}, Price: {value}");
                }
            }
        }
    }
}
