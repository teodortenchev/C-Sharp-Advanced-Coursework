using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P03_Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> data;
        private int index;
        public int Count { get; set; }

        public CustomStack()
        {
            data = new List<T>();
            index = 0;
            Count = 0;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T lastElement = data[Count - 1];
            data.RemoveAt(Count - 1);

            Count--;

            return lastElement;
        }

        public void Push(T element)
        {
            data.Add(element);
            this.Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
