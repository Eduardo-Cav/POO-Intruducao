using System;

namespace AulaPOOCelular.Celular
{
    // Faça em sua máquina o mesmo exemplo dado em aula.

    // - Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
    // - Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
    // - Só será possível executar tais métodos se o celular estiver ligado.
    // - Suba o projeto para um repositório no Github, com o título "AulaPOOCelular".
    // - Envie o link do repositório como entrega desta atividade.
    public class Smartphone
    {
        public string modelo;

        public string cor;

        public string tamanho;

        public bool ligado;

        public bool ligarCell;

        public bool desligandoCelular;

        public string ligacao;

        public string pessoa;

        public string contato;

        public string mensagem;

          public void LigarCelular(bool ligandoCelular){
            Console.WriteLine("Ligar celular? S/N");
            string ligarCell = Console.ReadLine();

            if(ligarCell.ToLower() == "S"){
                Console.WriteLine("*Ligando celular...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Celular Ligado");
            }else if (ligarCell.ToLower() == "N"){
                Console.WriteLine("*Celular Desligado");
            }

        }
        public void DesligarCelular(bool desligandoCelular){
            Console.WriteLine("desligar celular? S/N");
            string desligarCell = Console.ReadLine();

            if(desligarCell.ToLower() == "S"){
                Console.WriteLine("*desligando celular...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Celular desligado");
            }else if (desligarCell.ToLower() == "N"){
                 Console.WriteLine("*Celular permanece Desligado");     
            }
        
        }
        public void FazerLigacao(string ligacao, string pessoa){
            Console.WriteLine("Digite um contato para ligar: ");
            pessoa = Console.ReadLine();
            
            Console.WriteLine($"Ligando para {pessoa}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Chamada realizada");           
        }

        public void EnviarMensagem(string contato, string mensagem){
            Console.WriteLine("Enviar mensagem para quem?");
            contato = Console.ReadLine();
            
            Console.WriteLine("Digite a mensagem que deseja enviar: ");
            mensagem = Console.ReadLine();
            
            Console.WriteLine($"Enviado mensagem: {mensagem} para:{contato}");
        }


    }
}