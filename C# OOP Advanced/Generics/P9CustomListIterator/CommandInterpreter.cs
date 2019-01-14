
namespace P9CustomListIterator
{
    using System;

    public class CommandInterpreter<T> : ICommandInterpreter<T>
        where T : IComparable<T>
    {
        private CustomList<T> list;

        public CommandInterpreter()
        {
            list = new CustomList<T>();
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        public void Contains(T element)
        {
            Console.WriteLine(list.Contains(element));
        }

        public void Greater(T element)
        {
            Console.WriteLine(list.CountGreaterThan(element));
        }

        public void Max()
        {
            Console.WriteLine(list.Max());
        }

        public void Min()
        {
            Console.WriteLine(list.Min());
        }

        public void Print()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void Remove(int index)
        {
            list.Remove(index);
        }

        public void Swap(int index1, int index2)
        {
            list.Swap(index1, index2);
        }

        public void Sort()
        {
            list.Sort(); 
        }
    }
}
