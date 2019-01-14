namespace P8CustomListSorter
{
    using System;

    public class CustomList<T> : ICustomList<T>
        where T : IComparable<T>
    {

        private T[] array;
        private const int InitialCapacity = 4;
        public int Count { get; private set; }

        public CustomList()
        {
            array = new T[InitialCapacity];
            Count = 0;
        }

        public void Add(T element)
        {
            if (array.Length == Count)
            {
                this.Resize();
            }

            array[Count++] = element;



        }


        public bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public int CountGreaterThan(T element)
        {
            int counter = 0;

            for (int i = 0; i < Count; i++)
            {
                if (array[i].CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public T Max()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List has no elements.");

            }
            T result = array[0];

            for (int i = 1; i < Count; i++)
            {
                if (array[i].CompareTo(result) > 0)
                {
                    result = array[i];
                }
            }

            return result;
        }

        public T Min()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List has no elements.");

            }
            T result = array[0];

            for (int i = 0; i < Count; i++)
            {
                if (array[i].CompareTo(result) < 0)
                {
                    result = array[i];
                }
            }

            return result;
        }

        public T Remove(int index)
        {
            if (index < 0 || index > Count - 1)
            {
                throw new InvalidOperationException("Index is not in range.");
            }

            T temp = array[index];

            array[index] = default(T);

            Count--;

            for (int i = index; i < Count; i++)
            {
                array[i] = array[i + 1];
            }

            if(array.Length != Count)
            {
                array[Count] = default(T);
            }

            return temp;
        }

        public void Swap(int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public void Sort()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    if(array[i].CompareTo(array[j]) < 0)
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        private void Resize()
        {
            T[] tempArray = new T[array.Length * 2];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            array = tempArray;

        }

    }
}
