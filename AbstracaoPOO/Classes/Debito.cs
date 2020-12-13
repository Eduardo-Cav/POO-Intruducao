using System;

namespace AbstracaoPOO.Classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;

        public float Saldo{get {return saldo;}}

        
        public override void Pagar()
        {
            if(Valor < Saldo){
                Console.WriteLine("Compra aprovada com sucesso! Volte sempre!");
            }else{
                Console.WriteLine("Compra recusada!");
            }
        }

        public override void Processamento()
        {
            Console.WriteLine($"Digite o número do seu cartão de débito: ");
            numero = Console.ReadLine();
            
            do
            {
                
            if(numero.Length > 16 || numero.Length < 16){
               Console.WriteLine("Número de cartão inválido");
               Console.WriteLine($"Digite o número do seu cartão de crédito: ");
               numero = Console.ReadLine();  
            }
            } while (numero.Length > 16 || numero.Length < 16);
                
            
            Console.WriteLine($"Digite a bandeira: ");
            bandeira = Console.ReadLine();

            Console.WriteLine("Digite o nome do titular: ");
            titular = Console.ReadLine();

            Console.WriteLine("Digite a data de validade (Exemplo: 00/00): ");
            data = Console.ReadLine();
            do
            {                
            if(data.Length > 5 || data.Length < 5){
                Console.WriteLine("Escreva uma data válida");
                Console.WriteLine("Digite a data de validade (Exemplo: 00/00): ");
                data = Console.ReadLine();
            }     
            } while (data.Length > 5 || data.Length < 5);

            Console.WriteLine("CVV: ");
            cvv = Console.ReadLine();
            do
            {               
            if(cvv.Length > 3 || cvv.Length < 3){
                Console.WriteLine("Digite um cvv válido"); 
                Console.WriteLine("CVV: ");
                cvv = Console.ReadLine();               
            }  
            } while (cvv.Length > 3 || cvv.Length < 3);
        }
    }
}