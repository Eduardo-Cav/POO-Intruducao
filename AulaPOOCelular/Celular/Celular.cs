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

    

          public void LigarCelular(){                      
            
                Console.WriteLine("Ligando Celular...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Celular ligado");        
    
        }
        public void DesligarCelular(){
            Console.WriteLine("desligar celular? (true or false)");
            bool desligarCell = bool.Parse(Console.ReadLine());

                
            if(desligarCell == true){
                Console.WriteLine("desligando Celular...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Celular desligado!");
            }else if(desligarCell == false){
                Console.WriteLine("Celular permanece ligado");
            }    
        
           
        }
        public void FazerLigacao(){
            Console.WriteLine("Digite um contato para ligar: ");
            string pessoa = Console.ReadLine();
            
            Console.WriteLine($"Ligando para {pessoa}...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Chamada realizada");           
        }

        public void EnviarMensagem(){
            Console.WriteLine("Enviar mensagem para quem?");
            string contato = Console.ReadLine();
            
            Console.WriteLine("Digite a mensagem que deseja enviar: ");
            string mensagem = Console.ReadLine();
            
            Console.WriteLine($"Enviado mensagem: {mensagem} para: {contato}");
        }


    }
}