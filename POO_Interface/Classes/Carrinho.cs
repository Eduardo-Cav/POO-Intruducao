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
            Console.WriteLine("Alterar um produto? s/n");
            string resposta = Console.ReadLine();
            
            if(resposta == "s"){
            carrinho.Find(x => x.Codigo == code).Nome = product.Nome;
            carrinho.Find(x => x.Codigo == code).Preco = product.Preco;
            Console.WriteLine($"Você cadastrou o produto {product.Nome} com o valor de: {product.Preco}");
            }else{
                Console.WriteLine("Nenhuma alteração foi realizada");
            }
        }

        public void Cadastrar(Produto product)
        {
            Console.WriteLine($"Cadastrar Produto:");
            string resposta = Console.ReadLine();
            if(resposta == "s"){
            carrinho.Add(product);
            }else{
                Console.WriteLine($"Produto não cadastrado");
                
            }
        }

        public void Deletar(Produto product)
        {
            Console.WriteLine("Deseja remover algum produto s/n");
            string resposta = Console.ReadLine();
            if(resposta == "s"){

            carrinho.Remove(product);
            }else{
                Console.WriteLine($"Nenhum item foi excluido");
                
            }
        }
        public void Listar()
        {
            foreach (Produto item in carrinho)
            {
                Console.WriteLine($"O preço de {item.Nome} é: {item.Preco}");
            }
        }

    }
}