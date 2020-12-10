using System;

namespace PolimorfismoPOO.Classes
{
    public abstract class Player
    {
        public virtual void correr(){
            Console.WriteLine("Correndo em velocidade 10");
        }
    }
}