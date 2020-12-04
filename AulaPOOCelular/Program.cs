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

                
            Samsung.LigarCelular(Samsung.ligarCell);                                     
                
            int escolha;


            do{
                Console.WriteLine("O que deseja?");
                Console.WriteLine("[1] - Desligar celular");
                Console.WriteLine("[2] - Enviar Mensagem");
                Console.WriteLine("[3] - Fazer Ligação");
                Console.WriteLine("[0] - menu");

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                    Samsung.DesligarCelular(Samsung.desligandoCelular);
                    break;

                    case 2:
                    Samsung.EnviarMensagem(Samsung.contato, Samsung.mensagem);
                    break;

                    case 3:
                    Samsung.FazerLigacao(Samsung.ligacao, Samsung.pessoa);
                    break;

                    case 0:
                    Console.WriteLine("Ir para menu");
                    break;

                    default:
                    Console.WriteLine("Digite um numero válido");
                        break;
                }
                
            }while(escolha != 0);
        }
    }
}
