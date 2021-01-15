using System;
using System.Text;

namespace Pokedex.src.br.com.luishenrique.pokedex
{
    public class Pokemon
    {
        private string name;
        private string description;

        public Pokemon()
        {
            this.Name = "";
            this.Description = "";
        }

        public string Name
        {
            get { return name; }
            set { 
                    name = value.ToUpper(); 
                }
        }
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        public void showDataPokemon()
        {
            Console.WriteLine("Nome: "+Name);
            Console.WriteLine("Descrição: "+Description);
        }
    }
}