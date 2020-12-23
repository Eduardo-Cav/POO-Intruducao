using System;

namespace ProjetoProdutos.Classes
{
    public class Usuario
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Senha { get; set; }
        
        public DateTime DataCadastro {get; set;}

        public Usuario(){
            Cadastrar();
        }

        public Usuario(int code, string name, string email, string password){
            Nome = name;
            Codigo = code;
            Email = email;
            Senha = password;
            DataCadastro = DateTime.Now;
        }

        public void Cadastrar(){
            Nome = "dextroN";
            Email = "eduzika@hotmail.com";
            Senha ="123456";
            DataCadastro = DateTime.Now;
        }

        public void Deletar(){
            Nome = "";
            Email = "";
            Senha ="";
            DataCadastro = DateTime.Parse("");
        }
    }
}