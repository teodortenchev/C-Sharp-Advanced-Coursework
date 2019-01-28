namespace P04_InfernoInfinity.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class RarityFactory : IRarityFactory
    {
        public IRarity CreateRarity(string rarityType)
        {
            Type rarity = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == rarityType);

            IRarity rarityInstance = (IRarity)Activator.CreateInstance(rarity);

            return rarityInstance;
        }
    }
}
