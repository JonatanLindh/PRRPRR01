#nullable enable
using System;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_20
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            long sum = 0;
            while (sum < 1_000_000)
            {   
                sum += Input("Tal: ", int.Parse);
            }
            Console.WriteLine($"\nSumma: {sum}");
        }
    }
}