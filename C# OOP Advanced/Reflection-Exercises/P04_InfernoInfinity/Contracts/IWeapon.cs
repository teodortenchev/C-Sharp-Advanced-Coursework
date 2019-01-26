namespace P04_InfernoInfinity.Contracts
{
    using System.Collections.Generic;

    public interface IWeapon 
    {
        string Name { get; }
        int MinDamage { get; }
        int MaxDamage { get; }
        int SocketsCount { get; }
        int Strength { get; }
        int Agility { get; }
        int Vitality { get; }
        IList<IGem> Sockets { get; }
        void AddGem(int socketIndex, IGem gem);
        void RemoveGem(int socketIndex, IGem gem);
        IRarity Rarity { get; }
    }
}
