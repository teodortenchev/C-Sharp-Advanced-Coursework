using System;
using System.Collections.Generic;
using MilitaryElite.Contracts;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepairs> repairs;

        public Engineer(string firstName, string lastName, int id, decimal salary, Corps corps) 
            : base(firstName, lastName, id, salary, corps)
        {
            repairs = new List<IRepairs>();
        }

        public IReadOnlyCollection<IRepairs> Repairs { get => repairs.AsReadOnly(); }

        public void AddRepair(Repair repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            string firstLine = base.ToString() + Environment.NewLine 
                            + $"Corps: {Corps.ToString("f")}" + Environment.NewLine + "Repairs:";

            string secondLine = String.Join(Environment.NewLine, repairs.ToString());

            return firstLine + Environment.NewLine + secondLine;
        }
    }
}
