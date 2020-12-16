namespace ListaObjetos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }
        
        public Produto(){

        }

        public Produto(int code, string name, float price){
            // calcular o desconto
            Codigo = code;
            Nome = name;
            Preco = price;
        }

    }
}