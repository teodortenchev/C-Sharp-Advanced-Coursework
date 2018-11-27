using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string firstName, string lastName, int id, decimal salary, Corps corps)
            : base(firstName, lastName, id, salary, corps)
        {
            Missions = new List<IMission>();
        }

        public ICollection<IMission> Missions { get; set; }

        public override string ToString()
        {
            string firstLine = base.ToString()
                            + $"Corps: {Corps.ToString("f")}" + Environment.NewLine + "Missions:";

            string secondLine = String.Join(Environment.NewLine, Missions.ToString());

            return firstLine + Environment.NewLine + secondLine;
        }
    }
}
