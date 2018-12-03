using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, element;
            var trainers = new Dictionary<string, Trainer>();
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHP = int.Parse(tokens[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHP);

                if(!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }
                trainers[trainerName].AddPokemon(pokemon);
            }

            while ((element = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers.Values)
                {
                    if(trainer.Pokemons.Any(x => x.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(x => x.Health -= 10);
                        trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine(trainer);
            }
        }
    }
}
