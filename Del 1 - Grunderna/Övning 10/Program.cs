using System;

namespace Övning_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Belopp: ");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nUttag: {(amount / 100) * 100}");
        }
    }
}