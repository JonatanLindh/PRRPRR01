using System;

namespace Övning_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());
            
            Console.Write("Stop: ");
            int stop = int.Parse(Console.ReadLine());
            
            Console.Write("Steg: ");
            int step = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            
            for (int i = start; i <= stop; i+=step)
            {
                Console.Write($"{i} ");
            }
        }
    }
}