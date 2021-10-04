#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_4
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            double sideLen = Input("Sidlängd: ", double.Parse);

            Console.WriteLine($"\nTotal area: {Math.Pow(sideLen, 2) * 6 :f2} a.e.");
            Console.WriteLine($"Volym: {Math.Pow(sideLen, 3) :f2} v.e.");
        }
    }
}