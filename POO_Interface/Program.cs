using System;
using System.Collections.Generic;
using POO_Interface.Classes;

namespace POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
                       
            Produto product = new Produto();
            product.Codigo = 1;
            product.Nome = "God of War";
            product.Preco = 20f;

            Produto product2 = new Produto();
            product2.Codigo = 2;
            product2.Nome = "God of War 2";
            product2.Preco = 25f;

            Produto product3 = new Produto();
            product3.Codigo = 3;
            product3.Nome = "God of War 3";
            product3.Preco = 30f;

            carrinho.Cadastrar(product);
            carrinho.Cadastrar(product2);
            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Cyan;

            carrinho.Alterar(product.Codigo, product3);
            carrinho.Listar();



        }
            
    }
}
