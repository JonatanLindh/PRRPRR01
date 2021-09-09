using System;

namespace Övning_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radie: ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nOmkrets: {2 * r * Math.PI :f2} l.e.");
        }
    }
}