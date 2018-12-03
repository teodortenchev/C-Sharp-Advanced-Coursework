using System;

namespace FootballTeam
{
    public class Stats
    //endurance, sprint, dribble, passing and shooting
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;


        public int Endurance
        {
            get { return endurance; }
            private set
            {
                Validate(value, "Endurance");
                endurance = value;
            }
        }
        public int Sprint
        {
            get { return sprint; }
            private set
            {
                Validate(value, "Sprint");
                sprint = value;
            }
        }
        public int Dribble
        {
            get { return dribble; }
            private set
            {
                Validate(value, "Dribble");
                dribble = value;
            }
        }
        public int Passing
        {
            get { return passing; }
            private set
            {
                Validate(value, "Passing");
                passing = value;
            }
        }
        public int Shooting
        {
            get { return shooting; }
            private set
            {
                Validate(value, "Shooting");
                shooting = value;
            }
        }

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }


        private void Validate(int value, string statName)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{statName} should be between 0 and 100.");
            }
        }

    }
}
