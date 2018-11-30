using CollectionHierarchy.Contracts;


namespace CollectionHierarchy.CustomCollections
{
    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        /// <summary>
        /// Returns a string reprsentation of the collection's last element and removes it. 
        /// </summary>
        public virtual string Remove()
        {
            string removedItem = Data[Data.Count - 1].ToString();
            Data.RemoveAt(Data.Count - 1);
            return removedItem;
        }

        /// <summary>
        /// Adds an item to the beginnig of the collection and returns its index.
        /// </summary>
        /// <param name="item">Item to add.</param>
        /// <returns></returns>
        public override int Add(T item)
        {
            Data.Insert(0, item);
            return 0;
        }
    }
}
