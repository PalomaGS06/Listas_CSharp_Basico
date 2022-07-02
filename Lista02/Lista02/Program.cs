using System;

namespace Lista02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercício 9
      
            double saldo, credito;

            Console.WriteLine("Digite seu saldo:");
            saldo = double.Parse(Console.ReadLine());

            if ((saldo >= 0) && (saldo < 201))
            {
                credito = 0;

                Console.WriteLine("Nenhum crédito: "+ credito);

            }
            else if ((saldo >= 201) && (saldo < 401))

             { 
                credito = saldo * 0.2;

                Console.WriteLine("Acréscimo 20% do valor do seu saldo médio: " + credito);
            }

             else if ((saldo >= 401) && (saldo <= 600)) 

            {
                credito = saldo * 0.3;

                Console.WriteLine("Acréscimo de 30% do valor do seu saldo médio: "+ credito);
            }
        }
    }
}
