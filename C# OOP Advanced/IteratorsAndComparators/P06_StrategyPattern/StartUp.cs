using System;
using System.Collections.Generic;

namespace P06_StrategyPattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            SortedSet<Person> peopleByName = new SortedSet<Person>(new NameComparator());
            SortedSet<Person> peopleByAge = new SortedSet<Person>(new AgeComparator());


            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                peopleByName.Add(person);
                peopleByAge.Add(person);
            }

            //Console.WriteLine("By NAME:");
            foreach (var p in peopleByName)
            {
                Console.WriteLine(p);
            }
            //Console.WriteLine("By Age:");

            foreach (var p in peopleByAge)
            {
                Console.WriteLine(p);
            }
        }
    }
}
