using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

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
                            + Environment.NewLine +$"Corps: {Corps.ToString("f")}" + Environment.NewLine + "Missions:";

            string secondLine = ReturnMissions();

            if (Missions.Count == 0)
            {
                return firstLine;
            }
            return firstLine + Environment.NewLine + secondLine;
        }

        private string ReturnMissions()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var mission in Missions)
            {
                sb.AppendLine("  " + mission.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
