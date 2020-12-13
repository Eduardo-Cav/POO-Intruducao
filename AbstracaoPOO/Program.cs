using System;
using AbstracaoPOO.Classes;

namespace AbstracaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da compra: ");
            float valorDaCompra = float.Parse(Console.ReadLine());        
           
            Console.WriteLine("Selecione a forma de pagamento: ");
            Console.WriteLine("[1] - Boleto");
            Console.WriteLine("[2] - Cartão");
            int opcao = int.Parse(Console.ReadLine());           

            switch (opcao)
            {
                case 1:
                // boleto
                Boleto boleto = new Boleto();
                boleto.Registrar();
                boleto.Valor = valorDaCompra;
                boleto.Data = DateTime.Now;
                boleto.GerarBoleto(valorDaCompra);
                    break;
                case 2:
                //cartão
                Console.WriteLine("Selecione o tipo de cartão: ");
                Console.WriteLine("[1] - Crédito");
                Console.WriteLine("[2] - Débito");
                int tipo = int.Parse(Console.ReadLine());
                
                switch (tipo)
                {
                    case 1:
                    Credito credito = new Credito();
                    credito.Processamento();
                    credito.Valor = valorDaCompra;
                    credito.ParcelarCompra();
                    Console.WriteLine("Deseja salvar cartão: S/N");
                    string escolher = Console.ReadLine();
                    
                    switch (escolher)
                    {
                        case "S":
                        Console.WriteLine($"Número Cartão: {credito.numero}");
                        Console.WriteLine($"Bandeira: {credito.bandeira}");
                        Console.WriteLine($"Titular: {credito.titular}");
                        Console.WriteLine("Cartão salvo!");
                    break;
                        case "N":
                        Console.WriteLine ("Cartão não salvo!");
                        break;
                        default:
                        break;
                    }
                    credito.Pagar();
                        break;
                    case 2:
                    Debito debito = new Debito();
                    debito.Processamento();
                    debito.Valor = valorDaCompra;
                    Console.WriteLine("Deseja salvar seu cartão? S/N");
                    escolher = Console.ReadLine();                   

                    switch (escolher)
                    {
                        case "S":
                        Console.WriteLine($"Número Cartão: {debito.numero}");
                        Console.WriteLine($"Bandeira: {debito.bandeira}");
                        Console.WriteLine($"Titular: {debito.titular}");
                        Console.WriteLine("Cartão salvo!");
                        break;
                        case "N":
                        Console.WriteLine ("Cartão não salvo!");
                        break;

                        default:
                            break;
                    }
                    debito.Pagar();
                    break;
                    default:
                        break;
                }
                
                break;
                default:
                    break;
            }
             


        }
         
    }
}
