using System;
using System.Collections.Generic;
using System.Linq;

namespace P5FilterByAge
{
    class FilterByAge
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();
            int peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                string[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int personAge = int.Parse(input[1]);

                people.Add(new KeyValuePair<string, int>(name, personAge));
            }

            string filter = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split(' ');

            people = people.Where(p => filter == "younger" ? p.Value <= age : p.Value >= age).ToList();

            foreach (var person in people)
            {
                Printer(person, format);
            }

            
        }

        static void Printer(KeyValuePair<string, int> person, string[] pattern)
        {
            if (pattern.Length == 2)
            {
                Console.WriteLine(pattern[0] == "name" ? $"{person.Key} - {person.Value}" : 
                    $"{person.Value} - {person.Key}");
            }
            else
            {
                Console.WriteLine(pattern[0] == "name" ? $"{person.Key}" : $"{person.Value}");
            }
        }
    }
}
