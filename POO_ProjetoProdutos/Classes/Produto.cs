using System;
using System.Collections.Generic;

namespace ProjetoProdutos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string NomeProduto { get; set; }

        public float Preco { get; set; }
        
        public DateTime DataCadastro {get; set;}

        public Marca Marca = new Marca();

        public Usuario CadastroUsuario = new Usuario();

        public List<Produto> ListaProduto = new List<Produto>();

        public void Cadastrar(){
            Produto newProduct = new Produto();

            Console.WriteLine("Digite o código do seu produto: ");
            newProduct.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do seu produto: ");
            newProduct.NomeProduto = Console.ReadLine();
            
            Console.WriteLine("Digite o preço do seu produto: ");
            newProduct.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.Today;

            //chamamos um método do objeto/propriedade "Marca"
            newProduct.Marca = Marca.Cadastrar();

            //utilizamos o próprio método construtor para obter um objeto completo de usuário
            newProduct.CadastroUsuario = new Usuario();

            ListaProduto.Add(newProduct);
        }
        
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (Produto item in ListaProduto)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data do cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {item.CadastroUsuario.Nome}");     
            }
            Console.ResetColor();
        }
        
        public void Deletar(int code){
            Produto deletarProduto = ListaProduto.Find(x => x.Codigo == code);

            ListaProduto.Remove(deletarProduto);
        }
    }
}