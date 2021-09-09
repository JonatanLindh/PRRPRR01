using System;

namespace Övning_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Försäljningssumma: ");
            int sold = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nProdukt: {15000 + sold * 0.08 :f2} kr");
        }
    }
}