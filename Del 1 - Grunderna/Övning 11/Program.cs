#nullable enable
using System;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_11
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            int amount = Input("Belopp: ", int.Parse);

            int amount500 = (amount / 500) * 500;
            int amount100 = ((amount - amount500) / 100) * 100;
            
            Console.WriteLine($"\nUttag i 500-sedlar: {amount500}");
            Console.WriteLine($"Uttag i 100-sedlar: {amount100}");
        }
    }
}