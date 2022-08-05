using System;

namespace Lista_1___POO
{
    internal class Program3
    {
        static void Main(string[] args)

        {
            Jogador player = new Jogador("Sora"); //EXERC 8 -   metodo construtor passado o nome como argumento

            Console.WriteLine(player.Nome);
            Console.WriteLine(player.Vida);


            // // EXERC 6 -  Enum -> Máquina de estados: 
            player.TrocarAcao(); 

            // player.AcaoAtual = Jogador.Acoes.Atacando;

            player.Players();

        }
    }
}
