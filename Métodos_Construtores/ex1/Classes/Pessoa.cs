using System;

namespace ex1.Classes
{
    public class Pessoa
    {
        public string primeiroNome;

        public string sobrenome;

        public Pessoa(){
            
        }

        public Pessoa(string n, string s){
            primeiroNome = n;
            sobrenome = s;

            Console.WriteLine($"Bem vindo {primeiroNome} {sobrenome} ");
        }
    }
}