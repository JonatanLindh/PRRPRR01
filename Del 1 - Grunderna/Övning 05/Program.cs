using System;

namespace Övning_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Höjd: ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Längd: ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Bredd: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nVolym: {h * l * b} v.e.");
        }
    }
}