using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var dates = new DateModifier();

            Console.WriteLine(dates.CalculateDaysDifference(firstDate, secondDate).ToString());






            //Problem 4
            //List<Person> people = new List<Person>();
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string[] inputArgs = Console.ReadLine().Split();
            //    string name = inputArgs[0];
            //    int age = int.Parse(inputArgs[1]);

            //    if (age > 30)
            //    {
            //        people.Add(new Person(name, age));
            //    }

            //}
            //foreach (var person in people.OrderBy(x => x.Name))
            //{
            //    Console.WriteLine($"{person.Name} - {person.Age}");
            //}
        }
    }
}
