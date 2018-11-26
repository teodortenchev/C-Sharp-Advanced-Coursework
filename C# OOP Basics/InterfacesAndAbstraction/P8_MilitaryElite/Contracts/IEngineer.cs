using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepairs> Repairs { get; }
    }
}
