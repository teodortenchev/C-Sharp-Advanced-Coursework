using System;
using System.Collections.Generic;
using System.Linq;


namespace FootballTeam
{
    public class Player
    {
        private string name;
        private Stats stats;

        public Player(string name, Stats stats)
        {
            Name = name;
            Stats = stats;
        }


        public Stats Stats
        {
            get { return stats; }
            private set { stats = value; }
        }


        public int SkillLevel
        {
            get { return (int)Math.Round(CalculateSkill()); }
        }


        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        private double CalculateSkill()
        {
            List<int> statistics = new List<int>();
            statistics.Add(Stats.Endurance);
            statistics.Add(Stats.Sprint);
            statistics.Add(Stats.Dribble);
            statistics.Add(Stats.Passing);
            statistics.Add(Stats.Shooting);

            return statistics.Sum() / 5.0;

        }
    }
}
