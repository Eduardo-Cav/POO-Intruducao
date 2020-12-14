using System;

namespace POOstatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());

            Console.WriteLine($"Valor de Dólares para Reais: {Conversor.DolarParaReal(52):0.00} Reais");
            Console.WriteLine($"Valor de Real em Dólar: {Conversor.RealParaDolar(52):0.00} Dólares");

            Console.WriteLine("Digite um novo valor: ");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());

            Console.WriteLine($"Valor de Euro para Reais: {Conversor.EuroParaReal(52):0.00} Reais");
            Console.WriteLine($"Valor de Real em Euros: {Conversor.RealParaEuro(52):0.00} Euros");

        }
    }
}
