using System;

namespace Övning_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Täljare: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Nämnare: ");
            int denominator = int.Parse(Console.ReadLine());

            int whole = numerator / denominator;

            int newNumerator = numerator % denominator;
            string newFrac = (newNumerator == 0) ? "" : $" {newNumerator}/{denominator}";


            Console.WriteLine($"\n{numerator}/{denominator} blir {whole}{newFrac} i blandad form");
        }
    }
}