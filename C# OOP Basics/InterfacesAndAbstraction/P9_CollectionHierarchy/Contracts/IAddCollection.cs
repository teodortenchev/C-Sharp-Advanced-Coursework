using System.Collections.Generic;

namespace CollectionHierarchy.Contracts
{
    public interface IAddCollection<T>
    {
       
        /// <summary>
        /// Adds an item to the end of the collection and returns its index.
        /// </summary>
        int Add(T item);
    }
}
