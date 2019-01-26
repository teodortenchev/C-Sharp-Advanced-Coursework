﻿namespace P04_InfernoInfinity.Models.Weapons
{
    using Contracts;

    public class Knife : Weapon
    {
        private const int MaxGems = 2;

        public Knife(IRarity rarity, string name) : base(rarity, name, socketsCount: MaxGems)
        {
        }

    }
}
