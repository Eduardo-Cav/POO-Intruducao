using System;
using ObjetosArgumento.Classes;

namespace ObjetosArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação de produtos
            Produto p1 = new Produto(1, "Red Dead Redemption", 199.99f);
            Produto p2 = new Produto(2, "GTA V", 69.9f);
            Produto p3 = new Produto(3, "Detroit Become Human", 120.5f);
            Produto p4 = new Produto(4, "Celeste", 22.9f);

            Carrinho miniCar = new Carrinho();
            miniCar.AdicionarProduto(p1);
            miniCar.AdicionarProduto(p2);
            miniCar.AdicionarProduto(p3);
            miniCar.AdicionarProduto(p4);

            miniCar.MostrarProdutos();

            Produto p5 = new Produto(5, "Gta san adnreas", 10f);

            miniCar.AlterarItem(1, p5);

            miniCar.MostrarProdutos();
        }
    }
}
