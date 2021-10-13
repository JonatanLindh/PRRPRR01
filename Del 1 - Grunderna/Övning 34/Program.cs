#nullable enable
using System;
using System.Diagnostics;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_34
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            int age = Input("Ålder (år): ", int.Parse);
            int price = age switch
            {
                < 4 => 0,
                >= 4 and <= 17 => 16,
                _ => 25
            };

            Console.WriteLine($"\nPris: {price} kr.");
        }
    }
}