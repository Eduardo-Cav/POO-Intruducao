using System;
using EncapsulamentoPOO.Classes;

namespace EncapsulamentoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.ReceberNome("Eduardo Ferreira Cavalcanti");

            m.Numero = "4445556667788";

            m.Bandeira = "Visa";
            m.ExibirNome();
            m.Cvv = "858";
            Console.WriteLine($"Número do cartão: {m.Numero}");
            Console.WriteLine($"Bandeira: {m.Bandeira}");
            Console.WriteLine($"Cvv: {m.Cvv}");
            m.ExibirLimite();
            Console.WriteLine($"Número Token: {m.Token}");
            

        }
    }
}
