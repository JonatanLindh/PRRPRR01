#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_33
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            double distance = Input("Slagets distans: ", double.Parse);
            Console.WriteLine($"\nBollen hanmade {((distance is > 150 and < 190) ? "" : "inte ")}i dammen.");
        }
    }
}