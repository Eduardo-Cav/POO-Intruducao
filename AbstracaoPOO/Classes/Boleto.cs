namespace AbstracaoPOO.Classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public string CodigoDeBarras{get {return codigoDeBarras;}}

        public void Registrar(string valor){
            this.codigoDeBarras = valor;
        }

        public override string Desconto(float valor)
        {
            return "";
        }

        public override string Juros(float parcelas)
        {
            throw new System.NotImplementedException();
        }
    }
}