using System;
using poo;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
             //Instaciando objeto

          Personagem jogador1 = new Personagem();
          jogador1.nome = "dextroN";
          jogador1.idade = 16;
          jogador1.armadura = "Traje Adidas";

          Personagem jogador2 = new Personagem();
          jogador2.nome = "Natox";
          jogador2.idade = 10;
          jogador2.armadura = "MK3";
          
          Console.Clear();
          Console.WriteLine($"Partida = {jogador1.nome} VS {jogador2.nome}");
          Console.WriteLine($"Idade Jogador 1: {jogador1.idade} || Idade Jogador 2: {jogador2.idade}");
          Console.WriteLine($"Armadura Jogador 1: {jogador1.armadura} || Armadura Jogador 2: {jogador2.armadura}");
          Console.WriteLine($"Jogador 1 IA: {jogador1.iA} || Jogador 2 IA: {jogador2.iA}");

          int vidaDoJogador2 = jogador2.Defesa(jogador2.Ataque2());

          if(vidaDoJogador2 <= 0){
            Console.WriteLine("O jogador morreu");
          }else{
            Console.WriteLine($"Jogador 2 depois do ataque ficou com {jogador2.vida} de vida");   
        }
    
        }
    }
}
