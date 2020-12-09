namespace AbstracaoPOO.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;

        public string numero;

        public string titular;

        public string cvv;

        public string SalvarCartao(){
            return "";
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