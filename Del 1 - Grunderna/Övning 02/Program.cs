using System;

namespace Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tal a: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Tal b: ");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\na - b: {num1 - num2}");
            Console.WriteLine($"b - a: {num2 - num1}");
        }
    }
}