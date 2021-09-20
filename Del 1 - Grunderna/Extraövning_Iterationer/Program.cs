using System;

namespace Extraövning_Iterationer
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
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
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
        }

        static void D()
        {
            for (int i = 0; i < 12; i++)
            {
                //fib
            }
        }
    }
}