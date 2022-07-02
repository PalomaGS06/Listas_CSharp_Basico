using System;


namespace Lista03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exerc1();
            //Exerc2();
            //Exerc3();
            //Exerc4();
            //Exerc5();
            //Exerc6();
            //Exerc7();
            //Exerc8();
            //Exerc9();
            //Exerc10();

        }
        private static void Exerc1()
        {

            float n1, n2, n3, media;

            Console.WriteLine("Digite sua primeira nota: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            n3 = float.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("Sua média é: " + media);

            if (media >= 6)
            {
                Console.WriteLine("Aprovado(a)!!");

            }
            else
            {
                Console.WriteLine("Reprovado(a)!!");

            }
        }

        private static void Exerc2()
        {
            int a, b, c;

            Console.WriteLine("Digite um valor para 'a': ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para 'b': ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para 'c': ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {

                Console.WriteLine(a);
                Console.WriteLine("É o maior! ");
            }
            else
            if (b > a && b > c)
            {
                Console.WriteLine(b);
                Console.WriteLine("É o maior! ");

            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine("É o maior! ");
            }

            //    int maior = 0;
            //    int[] valor = new int[3];

            //    Console.WriteLine("Digite três valores: ");

            //    for (int x = 0; x < valor.Length; x++) // ou x < 3 ---> tamanho do vetor.
            //{  
            //    valor[x] = int.Parse(Console.ReadLine());  // x representa os valores aleatórios que a pessoa digitar.

            //    if (valor[x] > maior)
            //    {
            //        maior = valor[x];

            //    }
            //}

            //    Console.WriteLine(maior);
            //    Console.WriteLine("É o maior");


         

        }

        private static void Exerc3() {

            int a, b;

        Console.WriteLine("Digite dois valores inteiros:");
           
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("São múltiplos!");
            } else
            {
                Console.WriteLine("Não são múltiplos!");
            }
            Console.WriteLine("  ");
        }


        private static void Exerc4()
        {

            double peso, h;  //h = altura
            string sexo;

            Console.WriteLine("Digite sua altura: ");
            h = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu sexo m/f : ");
            sexo = Console.ReadLine();

            if (sexo == "m")
            {
                peso = (72.7 * h) - 58;

                Console.WriteLine("Seu peso ideal é: " + peso);

           }
            else if (sexo == "f")
            {

                peso = (62.1 * h) - 44.7;

                Console.WriteLine("Seu peso ideal é: " + peso);
            } 
            
            

            else
            {
                Console.WriteLine("Dados inválidos");
            }
        }


        private static void Exerc5()
        {
            //  int x=12, y=66;
            int x,y;
            
            Console.WriteLine("Digite dois valores:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine("Números iguais!");
            }

            else if (x > y)
            {
                Console.WriteLine("Primeiro é maior!");
            }
            else if (y > x)
            {

                Console.WriteLine("Segundo é maior");
            }


        }


        private static void Exerc6()
        {

            for (int i = 10; i >= 1; i--)
            {
                Console.Write(i+ "  ");

            }


            //int[] dec = new int[] { 6, 8, 1, 4, 3, 10, 9, 2, 7, 5 };


            //Array.Sort(dec);          // array.sort e array.reverse --> são dois métodos que, juntos,ordena de forma decrescente os dados de uma array. o Sort serve para colocar em ordem crescente
            //Array.Reverse(dec);       // o Reverse reverte a ordem. Como num espelho.
            //Console.WriteLine("Valores decrescentes: \n");
            //foreach (int i in dec)
            //{
            //    Console.Write(i + " ");
            //}


        }

        private static void Exerc7()
        {
            for (int x = 1; x <= 50; x++)
            {

                if (x % 5 == 0)
                {
                    Console.Write(x + "  ");
                }
            }

            //for (int x = 5; x <= 50; x+=5)
            //{
            //    Console.Write(x+"  ");
            //}
        }


        private static void Exerc8()
        {

            int n;

            Console.WriteLine("Digite um valor N: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Entre {n}, são pares:  ");

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "  ");
                }
            }
        }


        private static void Exerc9()
        {

            int n = 7, mult;
            
            Console.WriteLine("Multiplicação de sete: \n");

            for(int x = 1; x <= 10; x++)
            {
                mult = 7 * x;

                Console.WriteLine($"{n} X {x} = {mult}");

                

            }



        }


        private static void Exerc10()
        {
            int ant = 0, prox= 1, fib;
            
            

            Console.WriteLine("Série Fibonacci: \n");

                 for (int x = 1; x <= 15; x++)
            {
                                
                fib = prox;
                prox = prox + ant;
                ant = fib;
               
                Console.Write( $"{fib}  ");

            }

        }

    }

}




