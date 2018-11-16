using System;
using System.Collections.Generic;

namespace P4Countries
{
    class Countries
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] entry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


                if (!continents.ContainsKey(entry[0]))
                {
                    continents.Add(entry[0], new Dictionary<string, List<string>>());
                }
                if (!continents[entry[0]].ContainsKey(entry[1]))
                {
                    continents[entry[0]].Add(entry[1], new List<string>());
                }

                continents[entry[0]][entry[1]].Add(entry[2]);

                
            }

            foreach (var continent in continents)
            {
                string continentName = continent.Key;

                Console.WriteLine($"{continentName}:");
                foreach (var country in continent.Value)
                {
                    string countryName = country.Key;
                    List<string> cities = country.Value;
                    Console.WriteLine($"{countryName} -> {String.Join(", ", cities)}");
                }
            }
        }
    }
}
