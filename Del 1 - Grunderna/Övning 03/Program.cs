using System;

namespace Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Timmar: ");
            int hours = int.Parse(Console.ReadLine());
            
            Console.Write("Minuter: ");
            int minutes = int.Parse(Console.ReadLine());
            
            Console.Write("Sekunder: ");
            int seconds = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\nTid i sekunder: {hours * 3600 + minutes * 60 + seconds}s");
        }
    }
}