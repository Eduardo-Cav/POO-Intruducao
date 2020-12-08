namespace EncapsulamentoPOO.Classes
{
    public class MasterCard : Cartao
    {
        private int parcelas;

        public int Parcelas{get; set;}

        public void ExibirLimite(){
            System.Console.WriteLine($"O limite disponivel é de: {this.limite}");
        }
    }
}