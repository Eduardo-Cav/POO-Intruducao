using System;

namespace ex2.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public string Descricao{ get; set; }
        
        public int Estoque { get; set; }

        public Produto(int codigo, string nome, string descricao, int estoque){

            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;

            Console.WriteLine($"Código do produto: - {Codigo}, Nome: {Nome}");
        } //fim construtor

        public Produto(int codigo){
            if(codigo >= 0){
                Codigo = codigo;
                Console.WriteLine($"Código do produto: - {Codigo}, Nome: {Nome ?? "null"}");
            }else{
                Console.WriteLine("Código inexistente");
            }
        }
        
    }
}