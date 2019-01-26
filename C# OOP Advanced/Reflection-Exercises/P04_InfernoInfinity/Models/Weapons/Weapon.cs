namespace P04_InfernoInfinity.Models.Weapons
{
    using Contracts;
    using System;
    using System.Collections.Generic;

    public abstract class Weapon : IWeapon
    {
        private string name;
        private int minDamage;
        private int maxDamage;
        private int strength;
        private int agility;
        private int vitality;

        private IRarity rarity;

        private IGem[] sockets;


        protected Weapon(IRarity rarity, string name, int socketsCount)
        {
            Rarity = rarity;
            Name = name;
            SocketsCount = socketsCount;
            sockets = new IGem[SocketsCount];
            
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int MinDamage
        {
            get { return minDamage; }
            private set { minDamage = value; }
        }

        public int MaxDamage
        {
            get { return maxDamage; }
            private set { maxDamage = value; }
        }

        public int SocketsCount
        {
            get; private set;
        }

        public int Strength
        {
            get { return strength; }
            private set { strength = value; }
        }

        public int Agility
        {
            get { return agility; }
            private set { agility = value; }
        }

        public int Vitality
        {
            get { return vitality; }
            private set { vitality = value; }
        }

        //TODO: (i dont need this returned)
        public IList<IGem> Sockets => Array.AsReadOnly(sockets);


        public int DamageModifier => GetDamageMod();

        public IRarity Rarity
        {
            get { return rarity; }
            private set { rarity = value; }
        }

        private int GetDamageMod()
        {
            return rarity.DamageModifier;
        }

        public void AddGem(int socketIndex, IGem gem)
        {
            if (ValidSocket(socketIndex))
            {
                sockets[socketIndex] = gem;
                IncreaseStats(gem);
                
            }

        }
        /// <summary>
        /// Recalculates the modifiers based on weapon rarity.
        /// </summary>
        private void CalculateBoostFromStats()
        {
            MinDamage += Strength * 2 + Agility * 1 + DamageModifier;
            MaxDamage += Strength * 3 + Agility * 4 + DamageModifier;
            
        }


        public void RemoveGem(int socketIndex, IGem gem)
        {
            if (ValidSocket(socketIndex) && Sockets[socketIndex] != null)
            {
                sockets[socketIndex] = null;
                DecreaseStats(gem);
                
            }

        }

        private void IncreaseStats(IGem gem)
        {
            Strength += gem.StrengthIncrease;
            Agility += gem.AgilityIncrease;
            Vitality += gem.VitalityIncrease;
        }

        private void DecreaseStats(IGem gem)
        {
            Strength -= gem.StrengthIncrease;
            Agility -= gem.AgilityIncrease;
            Vitality -= gem.VitalityIncrease;
        }

        private bool ValidSocket(int socketIndex)
        {
            return socketIndex < 0 && socketIndex < sockets.Length;
        }

        public override string ToString()
        {
            CalculateBoostFromStats();
            return $"{Name}: {MinDamage}-{MaxDamage}, +{Strength} Strength, +{Agility} Agility, +{Vitality} Agility";
        }
    }
}
