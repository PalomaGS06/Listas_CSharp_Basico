using System;

namespace Exerc_8_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador player = new Jogador(10000); //EXERC 8 -   metodo construtor passado o nome como argumento
            ////player.Jogador();
            Console.WriteLine(player.Nome);
            Console.WriteLine(player.Vida);


            // // EXERC 6 -  Enum -> Máquina de estados: 
            // //player.TrocarAcao(); 

            // player.AcaoAtual = Jogador.Acoes.Atacando;
            player.Players();
        }
    }
}
