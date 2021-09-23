using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Extraövning_Iterationer
{
    class Program
    {
        static void Main(string[] args)
        {
            A();
            B();
            C();
            D();
            E();
            F();
        }

        static void A()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Write("\n\n\n");
        }

        static void B()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Write("\n\n\n");
        }

        static void C()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 9; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Write("\n\n\n");
        }

        static void D()
        {
            int n = 0;
            int m = 1;

            for (int i = 0; i < 12; i++)
            {
                string line = new String('*', m);
                int temp = m;
                m += n;
                n = temp;
                Console.WriteLine(line);
            }

            Console.Write("\n\n\n");
        }

        static void E()
        {
            int n = 0;
            int m = 1;

            for (int i = 0; i < 7; i++)
            {
                string line = string.Concat(Enumerable.Repeat("x ", m));

                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(line);
                }

                int temp = m;
                m += n;
                n = temp;

                Console.WriteLine();
            }

            Console.Write("\n\n\n");
        }

        static void F()
        {
            List<int> incr = Enumerable.Range(0, 15).ToList();
            List<int> decr = Enumerable.Range(0, 14).Reverse().ToList();
            incr.AddRange(decr);

            foreach (var i in incr)
            {
                string minus = new String('-', 14 - i);
                string plus = new String('+', i);
                Console.WriteLine($"{minus}{plus}+{plus}{minus}");
            }

            Console.Write("\n\n\n");
        }
    }
}