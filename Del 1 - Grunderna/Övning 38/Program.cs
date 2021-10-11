#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */


namespace Övning_38
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            double length = Input("Längd: ", double.Parse);
            double wind = Input("Vindstyrka: ", double.Parse);

            string result = (length > 7.92 && wind < 2.0) ? "Grattis, nytt rekord!" : "Tyvärr, inget nytt rekord";
            Console.WriteLine(result);
        }
    }
}