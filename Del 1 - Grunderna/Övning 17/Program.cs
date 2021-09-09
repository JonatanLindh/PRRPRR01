using System;

namespace Övning_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sluttal: ");
            int stop = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= stop ; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}