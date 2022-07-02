// Comentar linhas de código CTRL + K + C
// Descomentar linhas de código CTRL + K + U

using System;

namespace Lista01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  .........Letra A............

            int X, Y;
            X = 15;
            Y = 20;
            Console.WriteLine(X);
            /*    B = 3;   */
            Console.WriteLine($"{X},{Y}");



            //  .........Letra B............

            int A, B, C;
            A = 15;
            B = 3;
            C = A * B;
            Console.WriteLine(C);
            B = 10;
            C = A - B;
            Console.WriteLine($"{A},{B},{C}");



            //  .........Letra C............

            int x, y, z;
            x = 10; y = 12;
            z = x;
            y = z;
            x = y;
            Console.WriteLine($"{x},{y},{z}");



            //  .........Letra D............

            int a, b;
            a = 10;
            b = a + 2;
            a = b + 1;
            b = a + 1;
            Console.WriteLine(a);
            a = b + 1;
            Console.WriteLine($"{a},{b}");



            // .........Letra E............

            int o, p, q;
            o = 12;
            p = o;
            q = o + p;
            o = 20;
            p = 10;
            Console.WriteLine($"{o},{p},{q}");



            //.........Letra F............

            int c, d, e;
            c = 2;
            d = 3;
            c += d;
            e = c - d;
            Console.WriteLine(e);
            d = 5;
            Console.WriteLine($"{c},{d},{e}");


        }

    }
}
