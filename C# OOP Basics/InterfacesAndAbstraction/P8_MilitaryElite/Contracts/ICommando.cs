using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        ICollection<IMission> Missions { get; }

        /// <summary>
        /// Sets the state of the mission from In Progress to Finished.
        /// </summary>
       
    }
}
