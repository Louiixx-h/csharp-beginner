using System;

namespace aprendendo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Programa que calcula a idade de uma pessoa.");

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            
            Pessoa pessoa = new Pessoa(nome, anoNascimento);
            pessoa.ExibirDados();
        }
    }
}
