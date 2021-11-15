#nullable enable

using System;

namespace Uppgift_21
{
    class Program
    {
        static void Main(string[] args)
        {
            const int nextYear = 2022;
            for (int i = nextYear; i < nextYear + 10; i++)
            {
                var bd = new DateTime(i, 3, 28);
                Console.WriteLine($"{i}: {bd.DayOfWeek}");
            }
        }
    }
}