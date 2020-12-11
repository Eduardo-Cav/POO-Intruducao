using System;
using PolimorfismoPOO_Sobrecarga.Classes;


namespace PolimorfismoPOO_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Mostrar();
            funcionario.Mostrar("Eduardo");
            funcionario.Mostrar(3);
        }
    }
}
