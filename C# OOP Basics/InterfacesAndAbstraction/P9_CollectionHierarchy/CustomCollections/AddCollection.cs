using CollectionHierarchy.Contracts;
using System.Collections.Generic;

namespace CollectionHierarchy.CustomCollections
{
    public class AddCollection<T> : IAddCollection<T>
    {

        public AddCollection()
        {
            Data = new List<T>();
        }

        protected List<T> Data { get; private set; }

        
        /// <summary>
        /// Adds element at the end of the collection and returns its index.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public virtual int Add(T item)
        {
            Data.Add(item);
            return Data.Count - 1;
        }
    }
}
