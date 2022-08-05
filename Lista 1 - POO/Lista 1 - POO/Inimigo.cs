using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1___POO
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