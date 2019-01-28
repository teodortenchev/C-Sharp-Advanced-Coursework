namespace P04_InfernoInfinity.Models.Gems
{
    using Contracts;
    using Enums;
    using System;

    public abstract class Gem : IGem
    {
        private int strength;
        private int agility;
        private int vitality;

        protected Gem(string gemType, int strength, int agility, int vitality)
        {
            object result = Enum.Parse(typeof(GemQuality), gemType);
            StatsIncrease = (int)result;
            StrengthIncrease = strength;
            AgilityIncrease = agility;
            VitalityIncrease = vitality;
        }
        public int StrengthIncrease
        {
            get
            {
                return strength;
            }

            private set
            {
                strength = value + StatsIncrease;
            }
        }

        public int AgilityIncrease
        {
            get
            {
                return agility;
            }

            private set
            {
                agility = value + StatsIncrease;
            }
        }

        public int VitalityIncrease
        {
            get
            {
                return vitality;
            }

            private set
            {
                vitality = value + StatsIncrease;
            }
        }

        public int StatsIncrease { get; }


    }
}
