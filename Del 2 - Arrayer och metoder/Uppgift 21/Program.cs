#nullable enable

using System;
using System.Globalization;
using
    Superclasses; // https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%202%20-%20Arrayer%20och%20metoder/Superclasses/Class1.cs


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