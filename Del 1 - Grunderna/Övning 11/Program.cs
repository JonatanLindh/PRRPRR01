using System;

namespace Övning_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Belopp: ");
            int amount = int.Parse(Console.ReadLine());

            int amount500 = (amount / 500) * 500;
            int amount100 = ((amount - amount500) / 100) * 100;
            
            Console.WriteLine($"\nUttag i 500-sedlar: {amount500}");
            Console.WriteLine($"Uttag i 100-sedlar: {amount100}");
        }
    }
}