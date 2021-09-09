using System;

namespace Övning_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tal: ");
            int originalNum = int.Parse(Console.ReadLine());
            double num = (double) originalNum;
            num += 1;
            num *= 2;
            num -= 6;
            num /= 2;
            num += 3;
            num -= originalNum;

            Console.WriteLine($"\nNum (ska vara 1): {num}");
        }
    }
}