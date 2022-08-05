using System;

namespace TipoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Paloma Souza";
            int idade = 24;
            float peso = 56.1f;
            bool fazoCurso = true;

            var aulasFeitas = 42; //determina um tipo de dado e não pode mudá-lo.

            const int NUMERODEINSCRICAO = 6721; //constantes normalmente são em caixa alta.


            // -------------VETORES(ARRAYS)----------------------
            //indices               0              1              2
            string[] Livros = { "Harry Potter", "1984", "A Revolução dos Bichos" };



            // Operadores Aritméticos
            double num1 = 45;
            double num2 = 21;
            
            double resultado = num1 / num2;



            // Operadores Relacionais

            Console.WriteLine(num1 != num2);

            // Operadores Lógicos

            // OU - ||
            // E  - &&
            Console.WriteLine(num1 > num2 && num1 == num2);


            //Estrutura Condicional:

                // Simples
            if (idade > 18)
            {
                Console.WriteLine("Você ja pode tirar a carteira de motorista!");

            }

                // Composta

            if (idade > 18)
            {
                Console.WriteLine("Você ja pode tirar a carteira de motorista!");

            }
            else if (idade >= 16){

                Console.WriteLine("Você deve pedir autorização ao seu responsável para poder tirar a carteira de motorista!");
                
                }
            else
            {
                Console.WriteLine("Você ainda não pode tirar a carteira de motorista!");

            }
                

                // Encadeada  --> Um if dentro de outro
                if(idade > 15)
            {
                if (nome == "Paloma Souza")
                {
                    Console.WriteLine("Bem vinda ao Rock in Rio!");

                }

            }

        }

    }
}
