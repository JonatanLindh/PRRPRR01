#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace Övning_25
{
    class Program
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

        private static T Input<T>(string prompt, Func<string, T> parser)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(input))
                    {
                        throw new Exception();
                    }

                    var parsed = parser(input);
                    return parsed;
                }
                catch
                {
                    Console.WriteLine($"Kunde inte konvertera \"{input}\" till {typeof(T).Name}.\n");
                    continue;
                }
            }
        }
    }
}