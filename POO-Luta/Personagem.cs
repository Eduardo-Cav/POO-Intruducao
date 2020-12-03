namespace poo
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string iA = "AK-47";

        public int vida = 100;

        public int Ataque1(){
            return 100;
        }

        public int Ataque2(){
            return 20;
        }

        public int Defesa(int ataque){

            this.vida = this.vida - ataque;

            return this.vida;
        }
    }
}