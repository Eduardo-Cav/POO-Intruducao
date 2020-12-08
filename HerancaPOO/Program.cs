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
        
            pf.nome = "Eduardo Ferreira";

            pf.cpf = "46898539833";

            pj.cnpj = "123.456.789/1011-12"; 

            pj.inscricaoEstadual = "969.290.975.939";


            //Chamamos nosso metódo de saudação dentro de um consolewriteline
            Console.WriteLine(pf.darBoasVindas(pf.nome));  

            //Chamamos nosso metódo de validação de cpf dentro de um consolewriteline
            Console.WriteLine(pf.ValidarCPF(pf.cpf));
            
            Console.WriteLine(pj.ValidarCNPJ(pj.cnpj));
        }
    }
}
