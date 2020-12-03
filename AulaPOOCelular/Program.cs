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

            Console.WriteLine("Celular está ligado? ");
            Samsung.ligado = bool.Parse(Console.ReadLine());                                                       

          
        }
    }
}
