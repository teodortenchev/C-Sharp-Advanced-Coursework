using System;
using System.Collections.Generic;
using System.Text;
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

        public ICollection<IRepairs> Repairs { get => repairs.AsReadOnly(); }

        public void AddRepair(IRepairs repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            string firstLine = base.ToString() + Environment.NewLine 
                            + $"Corps: {Corps.ToString("f")}" + Environment.NewLine + "Repairs:";

            string secondLine = ReturnRepairs();

            if (Repairs.Count == 0)
            {
                return firstLine;
            }
            return firstLine + Environment.NewLine + secondLine ;

        }

        private string ReturnRepairs()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var repair in Repairs)
            {
                sb.AppendLine(repair.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
