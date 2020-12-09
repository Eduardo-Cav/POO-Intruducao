using System;

namespace AbstracaoPOO.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;

        protected float valor;

        public string Cancelar(){
           return "";
        }


        // Obrigatório nas classses herdadas
        public abstract string Desconto(float valor);

        public abstract string Juros(float parcelas);
    }
}