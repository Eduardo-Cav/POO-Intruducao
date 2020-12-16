using System;
using ex1.Classes;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            
            Pessoa pessoa = new Pessoa(nome, sobrenome);

            Pessoa pessoa2 = new Pessoa();
        
        }
    }
}
