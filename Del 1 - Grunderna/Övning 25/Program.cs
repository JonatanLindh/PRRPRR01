#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_25
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            // A();
            // B();
            // C();
            D();
        }

        static void A()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }

                Console.WriteLine();
            }
        }

        static void B()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i}*{j}={i * j}\t");
                }

                Console.WriteLine();
            }
        }

        static void C()
        {
            int from = Input("Tabeller från: ", int.Parse);
            int untill = Input("Till: ", int.Parse);
            int steps = Input("Steg i varje tabell: ", int.Parse);

            Console.WriteLine();

            for (int i = from; i <= untill; i++)
            {
                for (int j = 1; j <= steps; j++)
                {
                    Console.Write($"{i}*{j}={i * j}\t");
                }

                Console.WriteLine();
            }
        }

        static void D()
        {
            int sum = 0;

            int from = Input("Tabeller från: ", int.Parse);
            int untill = Input("Till: ", int.Parse);
            int steps = Input("Steg i varje tabell: ", int.Parse);

            Console.WriteLine();

            for (int i = from; i <= untill; i++)
            {
                for (int j = 1; j <= steps; j++)
                {
                    Console.Write($"{i}*{j}={i * j}\t");
                    sum += i * j;
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Summan av produkterna är: {sum}");
        }
    }
}