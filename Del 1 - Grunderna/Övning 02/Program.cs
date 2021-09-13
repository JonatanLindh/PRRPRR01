#nullable enable
using System;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_2
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            int num1 = Input("Tal a: ", int.Parse);
            int num2 = Input("Tal a: ", int.Parse);

            Console.WriteLine($"\na - b: {num1 - num2}");
            Console.WriteLine($"b - a: {num2 - num1}");
        }
    }
}