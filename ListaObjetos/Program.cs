using System;
using System.Collections.Generic;
using ListaObjetos.Classes;

namespace ListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
         // criar a lista
        List<Produto> produto = new List<Produto>();

        Produto[] prodArray = {};

        //método construtor Produtos instanciados com a variavel produto
        produto.Add(new Produto(1, "Apple Watch", 3522.50f));
        produto.Add(new Produto(2, "Xiamo Watch", 1578.42f));
        produto.Add(new Produto(3, "Zenfone Asus", 2321.87f));
        produto.Add(new Produto(4, "Samsung", 3346.34f));
        produto.Add(new Produto(5, "Motorola G8", 6873.15f));

        //instanciar um produto sozinho e atribuir seus valores
        Produto produto1 = new Produto();
        produto1.Codigo = 34;
        produto1.Nome = "Iphone XII";
        produto1.Preco = 8499.99f;

        produto.Add(produto1);

        //mostrar produtos
        foreach (Produto elemento in produto)
        {
            Console.WriteLine(elemento.Nome);       
        }
       
        //remover itens através do seu indice
        Console.WriteLine($"\nRemovido indice 3: \n");
        
        produto.RemoveAt(3);
        foreach (Produto elemento in produto)
        {
            Console.WriteLine(elemento.Nome);       
        }

        Console.WriteLine("\nRemovido código pelo nome ou codigo: \n");
        produto.RemoveAll(x => x.Nome == "Motorola G8");
        foreach (Produto elemento in produto)
        {
            Console.WriteLine(elemento.Nome);       
        }
    }
    }
}
