#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_3
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            int hours = Input("Timmar: ", int.Parse);
            int minutes = Input("Minuter: ", int.Parse);
            int seconds = Input("Sekunder: ", int.Parse);

            Console.WriteLine($"\nTid i sekunder: {hours * 3600 + minutes * 60 + seconds}s");
        }
    }
}