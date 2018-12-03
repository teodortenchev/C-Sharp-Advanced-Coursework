using System;
using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Trainer
    {
        //Trainers have a name, number of badges and a collection of pokemon, Pokemon have a name, an element and health, 
        //all values are mandatory. Every Trainer starts with 0 badges.
        private string name;
        private int badgesCount;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.BadgesCount = 0;
            this.Pokemons = new List<Pokemon>();
        }
        public Trainer(string name, List<Pokemon> pokemons) : this (name)
        {
            
            this.Pokemons = pokemons;
            
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }


        public int BadgesCount
        {
            get { return badgesCount; }
            set { badgesCount = value; }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }
        public void AddBadge()
        {
            this.BadgesCount++;
        }
        public void TakeDamage()
        {
            this.Pokemons.ForEach(p => p.ReduceHP());
            this.Pokemons.RemoveAll(p => p.Health <= 0);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.BadgesCount} {this.Pokemons.Count}";
        }

    }
}
