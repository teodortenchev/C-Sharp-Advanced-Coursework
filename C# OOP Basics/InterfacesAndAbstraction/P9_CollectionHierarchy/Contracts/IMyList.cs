namespace CollectionHierarchy.Contracts
{
    public interface IMyList<T> : IAddCollection<T>, IAddRemoveCollection<T>
    {
        /// <summary>
        /// Number of elements present in the collection.
        /// </summary>
        int Used { get; }
    }
}
