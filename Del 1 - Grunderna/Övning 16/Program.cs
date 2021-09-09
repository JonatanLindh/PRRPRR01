using System;

namespace Övning_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Multipel: ");
            int mult = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine(mult * i);
            }
        }
    }
}