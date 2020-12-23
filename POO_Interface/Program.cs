using System;
using System.Collections.Generic;
using POO_Interface.Classes;

namespace POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto product = new Produto();
            product.Codigo = 1;
            product.Nome = "God of War";
            product.Preco = 20f;
            
            Produto product2 = new Produto();
            product2.Codigo = 1;
            product2.Nome = "God of War 2";
            product2.Preco = 25f;
           
            Produto product3 = new Produto();
            product3.Codigo = 1;
            product3.Nome = "God of War 2";
            product3.Preco = 25f;
            
            Carrinho carrinho = new Carrinho();

            carrinho.Listar();

        }
            
    }
}
