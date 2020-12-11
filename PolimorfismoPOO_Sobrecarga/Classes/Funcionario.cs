using System;
namespace PolimorfismoPOO_Sobrecarga.Classes
{
    public class Funcionario
    {
        
        // a atividade começa aqui
        public string[] lista = {"Eduardo", "Pedro", "Nathan", "Fábio"};

        public void Mostrar(){

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        public void Mostrar(int indice){
            Console.WriteLine("Buscar por índice: " + lista[indice]);
        }

        public void Mostrar(string busca){
            foreach (var item in lista)
            {
                if(item == busca){
                    Console.WriteLine($"Buscando por item: {item}");
                }
            }
    
        }

        
        
    }
}
