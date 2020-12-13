using System;

namespace AbstracaoPOO.Classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;

        public float valorParcelado;

        public float Limite{get {return limite;}}



        public override void Pagar()
        {
            if(Valor < Limite){
                Console.WriteLine("Compra aprovada com sucesso! Volte sempre!");
            }else{
                Console.WriteLine("Compra recusada!");
            }
           
        }

        public override void Processamento()
        {
            Console.WriteLine($"Digite o número do seu cartão de crédito: {numero}");
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
        public void ParcelarCompra(){
            int parcelas;
            do
            {          
            Console.WriteLine("Digite a quantidade de vezes que deseja parcelar: ");
            Console.WriteLine("1 a 6 vezes - Juros de 5%");
            Console.WriteLine("7 a 12 vezes - Juros de 5%");
            parcelas = int.Parse(Console.ReadLine());

            if(parcelas > 12){
                Console.WriteLine("Valor inválido");
            }
            } while (parcelas > 12);
            
            if(parcelas < 7){
                valorParcelado = (Valor * 0.05f) + Valor;
                Console.WriteLine($"O valor da sua compra foi de: {Valor} para {valorParcelado} por conta da taxa de 5%");
            }else if(parcelas >= 7 && parcelas <= 12){
                valorParcelado = (Valor * 0.08f) + Valor;
            Console.WriteLine($"O valor da sua compra foi de: {Valor} para {valorParcelado} por conta da taxa de 8%");
            }
        }
    }
}