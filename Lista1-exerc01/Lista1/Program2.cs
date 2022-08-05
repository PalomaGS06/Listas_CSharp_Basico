using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            float[] number = { };
            
            Console.WriteLine(Calculadora.Somar(number));
            Console.WriteLine(Calculadora.Subtrair(number));
            Console.WriteLine(Calculadora.Multiplicar(number));
            Console.WriteLine(Calculadora.Dividir(number));
        }
    }
}
