using System;

namespace AbstracaoPOO.Classes
{
    public class Boleto : Pagamento
    {
        private float codigoDeBarras;

        public float CodigoDeBarras{get {return codigoDeBarras;}}

        public void Registrar(){
            Random random = new Random();
            this.codigoDeBarras = random.Next(9999999);
        }

        public void GerarBoleto(float valorDaCompra){
            float desconto = this.Valor * 0.12f;
            Console.WriteLine($"O valor do boleto é de: {this.Valor}");
            Console.WriteLine($"Valor com desconto de 12%: {this.Valor - desconto}");
            Console.WriteLine($"Data da compra: {this.Data}");
            Console.WriteLine($"Data de vencimento: {this.Data.AddDays(3)}");
            Console.WriteLine($"Código de barras - {this.CodigoDeBarras}");    
        }

    }
}