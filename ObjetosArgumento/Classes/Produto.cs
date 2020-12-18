namespace ObjetosArgumento.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }
        
        //primeiro metodo constutor
        public Produto(){

        }

        //método construtor que tem atributos como argumento, e atribui a instancia criada
        public Produto(int code, string name, float price){
            // calcular o desconto
            Codigo = code;
            Nome = name;
            Preco = price;
        }
    }
}