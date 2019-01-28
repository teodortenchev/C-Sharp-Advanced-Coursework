namespace P04_InfernoInfinity.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class GemFactory : IGemFactory
    {
        public IGem CreateGem(string gemType, string gemQuality)
        {
            Type gem = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == gemType);

            IGem gemInstance = (IGem)Activator.CreateInstance(gem, new object[] { gemQuality });

            return gemInstance;
        }
    }
}
