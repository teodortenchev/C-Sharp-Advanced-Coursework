namespace P03_BarraksWars.Core.Factories
{
    using Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type unit = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == unitType);
                
               

            IUnit soldier = (IUnit)Activator.CreateInstance(unit);

            return soldier;
        }
    }
}
