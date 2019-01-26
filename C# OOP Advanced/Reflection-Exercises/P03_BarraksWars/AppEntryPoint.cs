namespace P03_BarraksWars
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class AppEntryPoint
    {
        public static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();
            ICommandInterpreter commandInterpreter = new CommandInterpreter(serviceProvider);
            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            //It will be available temporarily while in use
            services.AddTransient<IUnitFactory, UnitFactory>();
            
            //Singleton pattern add, will create it when called for the first time and then will persist
            services.AddSingleton<IRepository, UnitRepository>();

            //Creates the service provider using the services addd to the IServiceCollection
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
