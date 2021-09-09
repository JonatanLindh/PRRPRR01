using System;

namespace Övning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sidlängd: ");
            int sideLen = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTotal area: {Math.Pow(sideLen, 2) * 6} a.e.");
            Console.WriteLine($"Volym: {Math.Pow(sideLen, 3)} v.e.");
        }
    }
}