namespace P04_InfernoInfinity
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();

            ICommandInterpreter commandInterpreter = new CommandInterpreter(serviceProvider);
            IEngine engine = new Engine(commandInterpreter);

            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<IInventory, Inventory>();
            services.AddTransient<IGemFactory, GemFactory>();
            services.AddTransient<IWeaponFactory, WeaponFactory>();
            services.AddTransient<IRarityFactory, RarityFactory>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }

    
}
