using P04_InfernoInfinity.Contracts;
using P04_InfernoInfinity.Enums;
using P04_InfernoInfinity.Models.Rarity;
using P04_InfernoInfinity.Models.Weapons;
using System;

namespace P04_InfernoInfinity
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IWeapon weapon = new Axe(new Rare(), "Axe of Mordor");
            //weapon.AddGem(1, new ());

            object result = Enum.Parse(typeof(GemQuality), "Chipped");
            int goro = (int)result;
            Console.WriteLine();
        }
    }
}
