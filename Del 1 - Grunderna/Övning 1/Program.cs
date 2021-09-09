using System;

namespace Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tal 1: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Tal 2: ");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\nProdukt: {num1 * num2}");
        }
    }
}