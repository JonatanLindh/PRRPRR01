using System;

namespace Övning_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Starttal: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Sluttal: ");
            int slut = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int i = start; i <= slut; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}