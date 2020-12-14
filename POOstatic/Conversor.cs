using System;
namespace POOstatic
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.12f;

        public static float valorUsuario;

        public static float RealParaDolar(float valorRS){
            return valorUsuario / cotacaoDolar;
        }

        public static float DolarParaReal(float valorUS){
            return cotacaoDolar * valorUsuario;
        }

        private static float cotacaoEuro = 6.22f;

        public static float RealParaEuro(float valorRS){
            return valorUsuario / cotacaoEuro;
        }
         public static float EuroParaReal(float valorUS){
            return cotacaoEuro * valorUsuario;
        }
    }
}