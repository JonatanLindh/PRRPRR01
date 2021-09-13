#nullable enable
using System;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_8
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            double sold = Input("Försäljningssumma: ", double.Parse);

            Console.WriteLine($"\nProdukt: {15000 + sold * 0.08 :f2} kr");
        }
    }
}