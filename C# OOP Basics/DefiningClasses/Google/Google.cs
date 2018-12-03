using System;
using System.Collections.Generic;
namespace Google
{
    class Google
    {
        static Dictionary<string, Person> people;
        static void Main(string[] args)
        {
            string input;
            people = new Dictionary<string, Person>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string command = tokens[1];

                if (!people.ContainsKey(name))
                {
                    people.Add(name, new Person(name));
                }
                people[name].AddInfo(tokens, command);
            }
            string searchPerson = Console.ReadLine();
            PrintResults(searchPerson);
        }

        public static void PrintResults(string searchPerson)
        {
            if(!people.ContainsKey(searchPerson))
            {
                Console.WriteLine("No such person in the database.");
                return;
            }
            Person resultPerson = people[searchPerson];
            resultPerson.PrintResults();
        }
    }
}
