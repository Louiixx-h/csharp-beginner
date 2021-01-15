using System;

namespace Pokedex.src.br.com.luishenrique.pokedex
{
    class PokemonApp
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Name = "Pikachu";
            pokemon.Description = "Pikachu é um pokemon de choque.";
            pokemon.showDataPokemon();
        }
    }
}
