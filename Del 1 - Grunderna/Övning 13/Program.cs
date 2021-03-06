#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_13
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            int numerator = Input("Täljare: ", int.Parse);
            int denominator = Input("Nämnare: ", s =>
            {
                int d = int.Parse(s);
                if (d == 0)
                {
                    throw new DivideByZeroException();
                }

                return (d);
            });
            
            int whole = numerator / denominator;
            int newNumerator = numerator % denominator;

            string ansFrac = (newNumerator == 0) ? "" : $" {newNumerator}/{denominator}";
            string ansWhole = whole == 0 ? "" : $" {whole}";

            Console.WriteLine($"\n{numerator}/{denominator} blir{ansWhole}{ansFrac} i blandad form");
        }
    }
}