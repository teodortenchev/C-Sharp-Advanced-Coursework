using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        ICollection<IRepairs> Repairs { get; }
        void AddRepair(IRepairs repair);
    }
}
