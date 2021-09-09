using System;

namespace Övning_24
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 0;
            long m = 1;

            while (n < 1_000_000)
            {
                Console.WriteLine(m);
                long next = n + m;
                n = m;
                m = next;
            };
        }
    }
}