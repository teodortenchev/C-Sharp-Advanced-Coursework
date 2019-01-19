using System.Collections.Generic;

namespace P06_StrategyPattern
{
    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person personOne, Person personTwo)
        {
            return personOne.Age.CompareTo(personTwo.Age);
        }
    }
}