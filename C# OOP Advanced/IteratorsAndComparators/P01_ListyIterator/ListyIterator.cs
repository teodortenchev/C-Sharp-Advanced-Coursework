using System;
using System.Collections.Generic;

namespace P01_ListyIterator
{
    public class ListyIterator<T>
    {
        private IReadOnlyList<T> data;
        private int currentIndex;

        public ListyIterator()
        {
            data = new List<T>();
            currentIndex = 0;
        }

        public void Create(params T[] parameters)
        {
            if (parameters.Length == 0)
            {
                return;
            }

            data = new List<T>(parameters);
        }

        public bool Move()
        {
            if (currentIndex < data.Count - 1)
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(data[currentIndex]);
        }

        public bool HasNext()
        {
            return currentIndex + 1 < data.Count;
        }
    }
}
