using CollectionHierarchy.Contracts;

namespace CollectionHierarchy.CustomCollections
{
    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        public int Used => GetElementsCount();


        private int GetElementsCount()
        {
            return base.Data.Count;
        }

        /// <summary>
        /// Removes an item from the beginning of the collection and returns the string representation of the removed item.
        /// </summary>
        public override string Remove()
        {
            string removedItem = base.Data[0].ToString();
            base.Data.RemoveAt(0);
            return removedItem;
        }
    }
}
