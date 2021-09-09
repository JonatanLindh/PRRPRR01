using System;

namespace Övning_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tal 1: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Tal 2: ");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.Write("Tal 3: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSumma: {num1 + num2 + num3}");
            Console.WriteLine($"\nMedelvärde: {(num1 + num2 + num3)/3.0 :f2}");
        }
    }
}