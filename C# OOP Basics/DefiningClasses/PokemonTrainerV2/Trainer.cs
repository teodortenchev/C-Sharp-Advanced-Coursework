using System.Collections.Generic;

namespace PokemonTrainerV2
{
    class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;
        

        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }
        
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }


        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
        }
    }
}
