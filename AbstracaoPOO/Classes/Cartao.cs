namespace AbstracaoPOO.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;

        public string numero;
        
        public string data;

        public string Numero{
            get{return numero;}
        } 

        public string titular;

        public string cvv;

        public abstract void Pagar();

        public abstract void Processamento();
    }
}