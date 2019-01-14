namespace P8CustomListSorter
{
    public interface ICommandInterpreter<T>
    {
        void Add(T element);
        void Remove(int index);
        void Contains(T element);
        void Swap(int index1, int index2);
        void Greater(T element);
        void Max();
        void Min();
        void Print();
        void Sort();
    }
}
