using System;
using HerancaPOO.Classes;

namespace HerancaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos a subclasse Pessoa fisica
            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();

            //Atribuimos um cpf ao objeto
        
          Console.WriteLine("Digite seu cpf: ");
          string cpf = Console.ReadLine();
          
          Console.WriteLine(PessoaFisica.IsCpf(cpf));



            //Chamamos nosso metódo de saudação dentro de um consolewriteline
            

            //Chamamos nosso metódo de validação de cpf dentro de um consolewriteline
         
        }
    }
}
