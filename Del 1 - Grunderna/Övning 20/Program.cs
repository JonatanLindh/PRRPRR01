using System;

namespace Övning_20
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            while (sum < 1_000_000)
            {   
                Console.Write("Tal: ");
                sum += long.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\nSumma: {sum}");
        }
    }
}