namespace CollectionHierarchy.Contracts
{
    public interface IAddRemoveCollection<T> : IAddCollection<T>
    {
        /// <summary>
        /// Removes the last item in the collection. Returns a string represantation of the removed item.
        /// </summary>
        string Remove();
    }
}
