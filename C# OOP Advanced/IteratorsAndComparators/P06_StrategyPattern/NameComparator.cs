using System;
using System.Collections.Generic;
using System.Text;

namespace P06_StrategyPattern
{
    /// <summary>
    /// Compares two people based on name length.
    /// </summary>
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int result = first.Name.Length.CompareTo(second.Name.Length);

            if (result == 0)
            {
                char firstPersonLetter = char.ToLower(first.Name[0]);
                char secondPersonLetter = char.ToLower(second.Name[0]);

                return firstPersonLetter.CompareTo(secondPersonLetter);

            }

            return result;
        }
    }
}
