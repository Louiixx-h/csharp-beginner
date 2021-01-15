using System;
using System.Text;

namespace aprendendo
{
    public class Pessoa
    {
        private string nome;
        private int anoNascimento;
        private int idade;
        
        public Pessoa(string nome, int anoNascimento)
        {
            this.nome = nome;
            this.anoNascimento = anoNascimento;
        }

        public string Nome
        {
            get{return nome;}
            set{nome = value;}
        }
        public int Idade
        {
            get { 
                    CalcularIdade();
                    return idade; 
                }
        }
        
        public int AnoNascimento
        {
            get{return anoNascimento;}
            set{anoNascimento = value;}
        }
        public void ExibirDados()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("Nome: "+ Nome);
            Console.WriteLine("Ano de nascimento: "+AnoNascimento);
            Console.WriteLine("Idade: "+Idade);
            Console.WriteLine("============================================");
        }
        private void CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            this.idade = ano - this.AnoNascimento;
        }
    }
}