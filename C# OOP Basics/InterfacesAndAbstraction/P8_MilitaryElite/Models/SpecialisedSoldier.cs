using MilitaryElite.Contracts;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string firstName, string lastName, int id, decimal salary, Corps corps) : base(firstName, lastName, id, salary)
        {
            Corps = corps;
        }

        public Corps Corps
        {
            get; private set;
        }
    }
}
