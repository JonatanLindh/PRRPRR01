#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_36
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            int num = Input("Tal: ", int.Parse);
            Console.WriteLine(num switch
            {
                < 0 => "\nTalet är negativt",
                0 => "\nTalet är 0",
                > 0 => "\nTalet är positivt",
            });
        }
    }
}












