using System;
using System.Collections.Generic;

namespace P05_ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (input != "END")
            {
                string[] peopleInfo = input.Split();
                string name = peopleInfo[0];
                int age = int.Parse(peopleInfo[1]);
                string town = peopleInfo[2];

                people.Add(new Person(name, age, town));

                input = Console.ReadLine();
            }

            int searchPersonNo = int.Parse(Console.ReadLine());

            if (searchPersonNo <= 0 || searchPersonNo > people.Count)
            {
                throw new ArgumentOutOfRangeException("Person number is outside the bounds of the list.");
            }

            Person searchedPerson = people[searchPersonNo - 1];

            int equalPeopleCount = 0;

            foreach (Person person in people)
            {
                if (searchedPerson.CompareTo(person) == 0)
                {
                    equalPeopleCount++;
                }
            }

            if (equalPeopleCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeopleCount} {people.Count - equalPeopleCount} {people.Count}");
            }

        }
    }
}
