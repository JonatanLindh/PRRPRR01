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
            Console.Write("Tabeller från: ");
            int from = int.Parse(Console.ReadLine());

            Console.Write("Till: ");
            int untill = int.Parse(Console.ReadLine());

            Console.Write("Steg i varje tabell: ");
            int steps = int.Parse(Console.ReadLine());

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

            Console.Write("Tabeller från: ");
            int from = int.Parse(Console.ReadLine());

            Console.Write("Till: ");
            int untill = int.Parse(Console.ReadLine());

            Console.Write("Steg i varje tabell: ");
            int steps = int.Parse(Console.ReadLine());

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