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
            MinDamage += DamageModifier;
            MaxDamage += DamageModifier;
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

        //TODO: Check if this creates problems, it should work fine, ensuring nobody tampers with the sockets
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

        private void IncreaseStats(IGem gem)
        {
            Strength += gem.StrengthIncrease;
            Agility += gem.AgilityIncrease;
            Vitality += gem.VitalityIncrease;
        }

        public void RemoveGem(int socketIndex, IGem gem)
        {
            if (ValidSocket(socketIndex) && Sockets[socketIndex] != null)
            {
                sockets[socketIndex] = null;
                DecreaseStats(gem);
            }

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
    }
}
