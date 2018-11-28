using CollectionHierarchy.Contracts;


namespace CollectionHierarchy.CustomCollections
{
    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        public virtual string Remove()
        {
            string removedItem = Data[Data.Count - 1].ToString();
            Data.RemoveAt(Data.Count - 1);
            return removedItem;
        }
    }
}
