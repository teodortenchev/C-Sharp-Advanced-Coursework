namespace P04_InfernoInfinity.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class WeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(IRarity rarity, string name, string type)
        {
            Type weaponType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == type);

            IWeapon weapon = (IWeapon)Activator.CreateInstance(weaponType, new object[] { rarity, name });

            return weapon;
        }
    }
}
