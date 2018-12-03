using System;
using System.Collections.Generic;

namespace FootballTeam
{
    public class Team
    {
        private int playerCount;
        private string name;
        public List<Player> teamMembers;

        public Team(string name)
        {
            Name = name;
            teamMembers = new List<Player>();
            playerCount = 0;
        }

        public void AddPlayer(Player player)
        {
            teamMembers.Add(player);
            playerCount++;
        }
        public void RemovePlayer(Player player)
        {
            if(!teamMembers.Contains(player))
            {
                throw new ArgumentException($"Player {player.Name} is not in {Name} team.");
            }
            teamMembers.Remove(player);
            playerCount--;
        }

        public int Rating
        {
            get { return (int)Math.Round(GetRating()); }
        }

        private double GetRating()
        {
            int totalRating = 0;

            foreach (var member in teamMembers)
            {
                totalRating += member.SkillLevel;
            }

            return totalRating / playerCount;
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

        public override string ToString()
        {
           if (playerCount == 0)
            {
                return $"{Name} - 0";
            }
            return $"{Name} - {Rating}";
        }

    }
}
