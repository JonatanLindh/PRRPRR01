#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_1
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            int num1 = Input("Tal 1: ", int.Parse);
            int num2 = Input("Tal 1: ", int.Parse);
            string hej = "asd";

            Console.WriteLine($"\nProdukt: {num1 * num2}");
        }
    }
}