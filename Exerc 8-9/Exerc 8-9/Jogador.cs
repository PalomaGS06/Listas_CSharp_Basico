using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_8_9
{
    public class Jogador
    {

        public string Nome { get; set; }
        public float Vida { get; set; } 
        public Acoes AcaoAtual { get; set; }

        public enum Acoes
        {
            Atacando,
            Defendendo,
            Pulando,
            Correndo
        }

        public void TrocarAcao()
        {

            Console.Write("Aperte as teclas para executar uma ação:  ");

            switch (Console.ReadLine().ToLower())
            {
                case "w":
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.Write(Acoes.Pulando);
                    Console.WriteLine(" ");
                    break;

                case "a":
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine(Acoes.Correndo);
                    Console.WriteLine(" ");
                    break;

                case "d":
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine(Acoes.Defendendo);
                    Console.WriteLine(" ");
                    break;

                case "s":
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine(Acoes.Atacando);
                    Console.WriteLine(" ");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nTecla inválida! Ação vazia...");
                    Console.WriteLine(" ");
                    break;

            }

        }

        //EXERC 7
        public string Morrer()
        {
            // Vida = 0;
            return "Game Over! ";
        }

        //EXERC 8

        public Jogador(string _nome)
        {
            Nome = _nome;

        }
        public Jogador(float _vida)
        {
            Vida = _vida;

        }


        //EXERC 10

        public string[] Jogadores = { "Sora", "Donald", "Goofy" };

        public void Players()
        {
            foreach (var kh in Jogadores)
            {
                Console.WriteLine(kh);
            }
        }
    }
}
