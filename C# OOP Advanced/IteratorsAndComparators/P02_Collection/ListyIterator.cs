using System;
using System.Collections;
using System.Collections.Generic;

namespace P02_Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private IReadOnlyList<T> data;
        private int currentIndex;

        public ListyIterator(T[] parameters)
        {
            data = new List<T>(parameters);
            currentIndex = 0;
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

        public void PrintAll()
        {
            Console.WriteLine(string.Join(' ', data));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
