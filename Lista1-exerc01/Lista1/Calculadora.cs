using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{   
        // EXERC 5 - Classe Estática
    public static class Calculadora
    {
        public static float Somar (float[] valor)
        {
            float calculo = 0;

            foreach (var numero in valor)
            {
                calculo = calculo + numero;
            }
            return calculo;
        }

        public static float Subtrair (float[] numeros)
        {
            float resultado = 0;

            foreach (var valor in numeros)
            {
                resultado -= valor;
            }
            return resultado;
        }

        public static float Multiplicar (float[] numeros)
        {
            float multiplicacao = 0;

            foreach (var valor in numeros)
            {
                multiplicacao = multiplicacao * valor;
            }
            return multiplicacao;
        }

        public static float Dividir(float[] valor)
        {
            try
            {
                if (valor.Length == 0)
                {
                    throw new Exception(" Valor inválido! ");

                }
                float divisao = valor[0];

                for (int x = 0; x < valor.Length; x++)
                {
                    divisao /= valor[x + 1];
                }
                return divisao;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Por favor, tente com valores válidos! ");
            }
        }
    }
}
