using System;
using System.Collections.Generic;

namespace POO_Interface.Classes
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal{get; set;}

        
        List<Produto> carrinho = new List<Produto>();
      
        public void Alterar(int code, Produto product)
        {
      
            carrinho.Find(x => x.Codigo == code).Nome = product.Nome;
            carrinho.Find(x => x.Codigo == code).Preco = product.Preco;
            
        }

        public void Cadastrar(Produto product)
        {

            carrinho.Add(product);
           
        }

        public void Deletar(Produto product)
        {

            carrinho.Remove(product);   
            
        }
        public void Listar()
        {
            foreach (Produto item in carrinho)
            {
                Console.WriteLine($" Nome: {item.Nome} Preço: {item.Preco} Código: {item.Codigo}");
            }
        }

    }
}