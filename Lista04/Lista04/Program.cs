using System;

namespace Lista04
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

        }


        private static void Exerc1()
        {
            int a, b, c, x;

            Console.WriteLine("Por favor, digite 3 números para serem calculados:");
            a =int.Parse(Console.ReadLine());
            b =int.Parse(Console.ReadLine());
            c =int.Parse(Console.ReadLine());
            
            x = (a + b) / c;

            Console.WriteLine(" ");
            Console.WriteLine($"O cálculo da expressão é: {x}");

        }


        private static void Exerc2()
        {

            double n1, n2, n3, mediap;
            const int P1 = 2, P2 = 3, P3 = 5;

            Console.WriteLine("Digite suas notas das 3 provas: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            mediap = ((n1 * P1) + (n2 * P2) + (n3 * P3))/(P1+P2+P3);

            // a função Math.Round() abaixo, arrendonda valores, com a casa que vc quiser definir depois da virgula.
            // no exemplo abaixo, de horas, defini 2 casas depois da vírgula e de minutos, 0 casas depois da vírgula.

            Console.WriteLine(" ");
            Console.WriteLine("Sua média ponderada é: " + Math.Round(mediap,2));
        }

        private static void Exerc3() 
        {
            int tempo = 4500;
            double horas=0, minutos=0, segundos=0;

            Console.WriteLine($"O evento X da fábrica Y tem duração de {tempo} segundos! ");

            if (tempo >= 3600)
            {
              horas = tempo / 3600;
            }
            if (tempo % 3600 >= 60)
            {
                minutos = (tempo % 3600) / 60;
            }
            if (tempo % 3600 % 60 >= 0)
            {
                segundos = (tempo % 3600 % 60);
            }
                   
            Console.WriteLine(" ");
            //Console.WriteLine($" O evento tem ao total:  {horas}  hora(s), {minutos} minuto(s) e {segundos} segundo(s)");
            Console.WriteLine($"O evento tem duração de: {horas:00} : {minutos:00} : {segundos:00}");
        }


        private static void Exerc4()
        {

            int l = 4;

            double area;


            Console.WriteLine($" Dado o lado de um triângulo equilátero igual a {l}, calcule sua área.");

            area = (Math.Pow(l, 2) * Math.Sqrt(3)) / 4;

            Console.WriteLine(" ");
            Console.WriteLine("A área do triângulo equilátero é: " +Math.Round(area,2));


        }


        private static void Exerc5()
        {

            int a, b, c;
             float x;

            Console.Write(" ");
            Console.WriteLine("Digite 3 valores inteiros: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());


            x = (float)Math.Pow((a + b), 2) + c;

            Console.Write(" ");
            Console.Write("O resultado da fórmula dada será: " + x);


        }


        private static void Exerc6()
        {
            int i;

            Console.WriteLine("Digite um valor: ");
            i=int.Parse(Console.ReadLine());

            //i= (int)Math.Pow((i-1),2);
            
            i = (i - 1) * 2;

            Console.WriteLine("O dobro do valor do seu antecessor é: "+i);

        }


        private static void Exerc7()
        {
            double total_eleit = 280;
            double votosb = 54;
            double votosn = 140;
            double votosv = 86;
            double porcb, porcn, porcv;

            Console.WriteLine($"Para o total de eleitores que representam {total_eleit}, foram calculados o percentual de cada tipo de voto:");
            Console.WriteLine(" ");

            if (votosb > 0)
            {
                porcb = 100 * (votosb / total_eleit);
                Console.WriteLine("A porcentagem de votos brancos é: " + Math.Round(porcb,1) + "%");

            }
            if (votosn >= 0)
            {
                porcn = 100 * (votosn / total_eleit);
                Console.WriteLine("A porcentagem de votos nulos é: " + Math.Round(porcn,1) + "%");

            }

            if(votosv > 0)
            {
                porcv = 100 * (votosv / total_eleit);
                Console.WriteLine("A porcentagem de votos válidos é: " + Math.Round(porcv,1) + "%");

            }

        }


        private static void Exerc8()
        {

            double custo_cons,custo_fab;
           const double  PORC_DIST= 0.30;
            const double PORC_IMP = 0.45;
            double distribuidor, impostos;

            Console.Write("Informar o valor do custo de fábrica do carro: R$");
            custo_fab = double.Parse(Console.ReadLine());

            distribuidor = PORC_DIST * custo_fab;
            impostos = PORC_IMP * custo_fab;

            //distribuidor = (30 * custo_fab) / 100;
            //impostos = (45 * custo_fab) / 100;

            custo_cons = custo_fab + distribuidor + impostos;

            Console.WriteLine(" ");
            Console.WriteLine(" O custo do consumidor será: R$" +custo_cons);
        }


    }
}

