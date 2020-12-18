using System;
using System.Collections.Generic;

namespace ObjetosArgumento.Classes
{
    public class Carrinho
    {
        //armazena o valor total dos produtos no carrinho
        public float valorTotal { get; set; }
        
        //criação da lista de produtos, que é carrinho
        List<Produto> carrinho = new List<Produto>();

        //adiciona o produto na lista carrinho
        public void AdicionarProduto(Produto product){
            carrinho.Add(product);
        }

        public void MostrarProdutos(){
            if(carrinho != null){
                foreach (Produto item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{item.Codigo}. {item.Nome}, {item.Preco}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }
        public void RemoverProduto(Produto product){
            carrinho.Remove(product);
        }
        public void MostrarTotal(){
            if(carrinho != null){
                valorTotal = 0;
                foreach (var item in carrinho)
                {
                   valorTotal += item.Preco;
                }
                Console.WriteLine($"O valor total é de {valorTotal}");
            }else{
                Console.WriteLine("Seu carrinho está vázio!");
            }
        }

        //x = item do carrinho
        public void AlterarItem(int code, Produto newProduct){
            carrinho.Find(produto => produto.Codigo == code).Nome = newProduct.Nome;
            carrinho.Find(produto => produto.Codigo == code).Preco = newProduct.Preco;
        }
    }
}