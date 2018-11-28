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

        

        public virtual int Add(T item)
        {
            Data.Add(item);
            return Data.Count - 1;
        }
    }
}
