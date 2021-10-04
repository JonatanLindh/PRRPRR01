#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_5
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            double h = Input("Höjd: ", double.Parse);
            double l = Input("Längd: ", double.Parse);
            double b = Input("Bredd: ", double.Parse);
            
            Console.WriteLine($"\nVolym: {h * l * b :f2} v.e.");
        }
    }
}