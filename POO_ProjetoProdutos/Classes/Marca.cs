using System;
using System.Collections.Generic;

namespace ProjetoProdutos.Classes
{
    public class Marca
    {
        public int Codigo { get; set; }
        
        public string NomeMarca { get; set; }

        public DateTime DataCadastro {get; set;}

        public List<Marca> ListaDeMarcas = new List<Marca>();

        public Marca Cadastrar(){
        Marca novaMarca = new Marca();

        Console.WriteLine("Digite o código da sua marca: ");
        novaMarca.Codigo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Nome da sua marca: ");
        novaMarca.NomeMarca = Console.ReadLine();

        DataCadastro = DateTime.Now;
        
        ListaDeMarcas.Add(novaMarca);

        return novaMarca;
        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (Marca item in ListaDeMarcas)
            {
                Console.WriteLine($"O código de sua marca é: {item.Codigo}");
                Console.WriteLine($"Nome da marca: {item.NomeMarca}");
                Console.WriteLine($"Data do cadastro: {item.DataCadastro}");
            }
            Console.ResetColor();
        }

        public void Deletar(int code){
            Marca MarcaDelete = ListaDeMarcas.Find(x => x.Codigo == code);

            ListaDeMarcas.Remove(MarcaDelete);
        }
        
        
    }
}