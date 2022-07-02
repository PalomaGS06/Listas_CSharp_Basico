using System;

namespace Lista06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exerc01();
            //Exerc02();
            //Exerc03();
            //Exerc04();
            //Exerc05();
            //Exerc06();
            //Exerc07();
            //Exerc08();
            //Exerc09();
            Console.WriteLine("A quantidade de dígitos deste valor é: " +Exerc10());

        }

        private static void Exerc01()
        {
            int[] val = new int[8];                         

            for (int i = 0; i < val.Length; i++)
            {
                val[i] = (int)Math.Pow(i,3);

                Console.Write(val[i]+ " ");
            }

        }

        private static void Exerc02()
        {
            int[] v = { 5, 1, 4, 2, 7, 8, 3, 6 };
           int[]v2 = new int[8];

            Console.Write(" V = ");

            //ler o primeiro vetor
            for (int x = 0; x < v.Length; x++)
            {
                
                Console.Write(v[x] + "  ");

            }                
            Console.WriteLine(" ");
            Console.Write(" V2 = ");

            //ler o segundo vetor
            for (int x = 0; x < v2.Length; x++)
            {
                v2[x] = v[x] * 2;
                             
                    Console.Write(v2[x] + "  ");
                    
            } 
               Console.WriteLine(" ");

        }

        private static void Exerc03()
        {

            int[] a = new int[10];
            int[] m = new int[10];
            int x ;

            Console.WriteLine("Digite dez valores inteiros: ");
            Console.WriteLine("A = ");

            for (int i = 0; i < a.Length; i++)
            {
             
                a[i] = int.Parse(Console.ReadLine());
            
            }   
                Console.Write(" ");
                Console.WriteLine("Digite mais um valor inteiro: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                 Console.Write("Os valores de M são:  ");
            

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = a[i] * x;

                Console.Write(m[i] + "  ");
                Console.Write(" ");
            }
           
        }

        private static void Exerc04()
        {

            string[] v = new string[5];
            string nome;
            Boolean acharnome=false;
            

            Console.WriteLine("Digite cinco nomes: ");
           
            for (int i = 0; i < v.Length; i++)
            {

                v[i] = Console.ReadLine();
           }

            Console.WriteLine(" ");
            Console.Write("Digite o nome que queira encontrar: ");
            nome= Console.ReadLine();
            Console.WriteLine(" ");

            for (int i = 0; i < v.Length; i++)
            {            
                               
                if ( v[i] == nome)
                {
                    acharnome = true;
                    break;
                }   
            }
                if (acharnome)
            
                Console.WriteLine("ACHEI!!");
            
                else

                Console.WriteLine("NÃO ACHEI!!");
                
        }

        private static void Exerc05()
        {
            int[] q = new int[10];
            int posicao = 0;
            int maior;

            Console.WriteLine("Digite dez números: ");

            for (int i=0; i < q.Length; i++)
            { 
                q[i] = int.Parse(Console.ReadLine());

                if (q[i] % 2 != 0)
                {
                    Console.WriteLine("Esse número não é par, digite outro:");
                    q[i] = int.Parse(Console.ReadLine());
                }
            }

            maior = q[0];
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] >= maior)
                {
                    maior = q[i];
                }
            }

            for (int i = 0; i < q.Length; i++)
            {
                if (maior == q[i])
                {
                    posicao = i;
                    Console.WriteLine($"O maior número é {maior} que está na posição {posicao}!");
                }
            }
        }

        private static void Exerc06()
        {

            int[] temp= new int[7];
            int media, menor, maior, dias_menor_media=0, soma=0;
             
            Console.WriteLine("Digite as temperaturas de cada dia da semana, respectivamente: ");
                       

                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = int.Parse(Console.ReadLine());
                      soma += temp[i];
                }

                maior = temp[0];
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] >= maior)
                    {
                        maior = temp[i];

                    }
                }
            for (int i = 0; i < temp.Length; i++)
            {
                if (maior == temp[i])
                {
                    Console.WriteLine("A maior temperatura semanal é : " + maior + "ºC");

                }
            }
            menor = temp[0];
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] <= menor)
                {
                    menor = temp[i];

                }
            }
            for (int i = 0; i < temp.Length; i++)
            {
                if (menor == temp[i])
                {
                    Console.WriteLine("A menor temperatura semanal é : " + menor + "ºC");

                }
            }
                                media = soma / 7;
                  Console.WriteLine("A média da temperatura semanal é: "+ media+ "ºC");
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < media)
                {
                    dias_menor_media += 1;
                                    

                }

            }
                Console.WriteLine("O número de dias da semana em que a temperatura foi inferior a média semanal foi de: " + dias_menor_media + " dias");
        }

        private static void Exerc07()
        {
           int[] valores = new int[10];
            //int aux = 0;
           Console.WriteLine("Digite dez números aleatórios: \n");

           // for (int i = 0; i < valores.Length; i++)
           // {
           //     valores[i] = int.Parse(Console.ReadLine());
           //     for (int x= 0; x < valores.Length; x++)
           //     {
           //         if (valores[i] < valores[x])
           //         {
           //             aux = valores[i];
           //             valores[i] = valores[x];
           //             valores[x] = aux;
           //         }
           //     }
           // }

           // for (int i = 0; i < valores.Length; i++)
           // {
           //     Console.Write(valores[i] + "   ");
           // }
            for (int i = 0; i <= valores.Length; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());
            }

            Console.Write(" ");
            Array.Sort(valores);
                Console.Write("Valores em ordem crescente: \n");
            foreach (int ordem in valores)
            {

                Console.Write(ordem+" ");
            }
        }

        private static void Exerc08()
        {

             int Soma(int a,int b,int c)
            {
                int somar = a + b + c;

                return (somar);
            }


             double Media (int x, int y, int z)
            {
                int res = Soma(x, y, z)/3 ;
              
                return (res);
                //return (res/3);
            }
                        
                int x, y, z, media=0;

                Console.Write("Digite o primeiro número: ");
                x = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                y = int.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro número: ");
                z = int.Parse(Console.ReadLine());

                Console.Write("A soma dos três números é: " + Soma( x,y,z)+ "\n");

                Console.Write("A média dos três números é: " + Media(x, y, z) + "\n");

            //Console.Write("A média dos três números é: " + Media(Soma(x,y,z)) + "\n");
        }

        private static void Exerc09()
        {
            static string Valores(double val)
            {  
                if (val > 0)
                {
                    return ("P");

                }
                else
                {
                    return ("N");
                }
            }

            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("\n"+Valores(x)+ " ");
        }

        private static int Exerc10()
        {
            int dig = 0, valor;

            Console.WriteLine("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());

            do
            {
                dig++;
                valor = valor / 10;
            }
            while (valor != 0);
           
            return dig;

        }
    }

}
