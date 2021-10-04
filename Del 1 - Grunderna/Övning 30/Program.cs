#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */
namespace Övning_30
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            double weight = Input("Vikt (hg): ", double.Parse);
            double hgPrice = Input("Pris (kr/hg): ", double.Parse);

            Console.WriteLine($"\nPris: {((weight >= 5) ? weight * hgPrice * 0.9 : weight * hgPrice) :f2} kr");
        }
    }
}