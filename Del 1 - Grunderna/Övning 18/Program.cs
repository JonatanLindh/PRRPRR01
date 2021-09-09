using System;

namespace Övning_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Multipel: ");
            int mult = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine(mult * i);
                i++;
            }
        }
    }
}