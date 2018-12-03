using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string input, element;

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(name))
                {
                    trainers.Add(name, new Trainer(name));
                }
                trainers[name].AddPokemon(pokemon);
            }

            while ((element = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    if(trainer.Pokemons.Any(x => x.Element == element))
                    {
                        trainer.AddBadge();
                    }
                    else
                    {
                        trainer.TakeDamage();
                    }
                }
            }

            foreach (var trainer in trainers.Values.OrderByDescending(x=> x.BadgesCount))
            {
                Console.WriteLine(trainer);
            }
        }
    }
}
