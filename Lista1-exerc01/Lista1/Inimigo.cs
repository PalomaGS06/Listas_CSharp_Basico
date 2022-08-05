
using System;

namespace Lista1
{
    public class Inimigo
    {
        public string Nome;
        private float Vida { get; set; }
        public virtual string Atacar()
        {
         
            return "O inimigo está em modo de ataque, cuidado!";
        }

        public string Defender()
        {
                // EXERC 2 
            Vida = 100;
            Vida -= 5;
           //Console.WriteLine($" HP: {Vida} ");
            return "O inimigo está se defendendo! Bloqueia sua defesa! ";
        }

    }
}
