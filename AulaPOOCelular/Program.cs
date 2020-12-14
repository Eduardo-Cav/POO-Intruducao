using System;
using AulaPOOCelular.Celular;


namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone Samsung = new Smartphone();
            
        


            Console.WriteLine("Qual o modelo do celular: ");
            Samsung.modelo = Console.ReadLine();

            Console.WriteLine("Cor do modelo: ");
            Samsung.cor = Console.ReadLine();

            Console.WriteLine("Tamanho do celular: ");
            Samsung.tamanho = Console.ReadLine();


            Console.WriteLine($"Celular: {Samsung.modelo}");
            Console.WriteLine($"Cor: {Samsung.cor}");
            Console.WriteLine($"Tamanho: {Samsung.tamanho}");   
            
            Console.WriteLine("Deseja Ligar o celular? S/N");
            string escolha = Console.ReadLine();
            
            int escolher;

            switch (escolha)
            {
                case "S":
                Samsung.LigarCelular();
                do
                {
                    
                Console.WriteLine("O que deseja?");
                Console.WriteLine("[1] - Desligar celular");
                Console.WriteLine("[2] - Enviar Mensagem");
                Console.WriteLine("[3] - Fazer Ligação");
                Console.WriteLine("[0] - menu");
                escolher = int.Parse(Console.ReadLine());
                    
                switch (escolher)
                {
                    case 1:                                      
                    Samsung.DesligarCelular();                  
                      break;
                    case 2:
                    Samsung.EnviarMensagem();
                    break;
                    case 3:
                    Samsung.FazerLigacao();
                    break;
                    default:
                    Console.WriteLine("Saindo para o menu");
                    break;
                }
                
                } while (escolher != 1);
                    break;
                case "N": 
                Console.WriteLine("Celular Desligado.");
                break;
                default:
                    break;
            }
        
    

        }
    }
}
