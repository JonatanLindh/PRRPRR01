#nullable enable
using System;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */
namespace Övning_31
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            double num1 = Input("Tal 1: ", double.Parse);
            double num2 = Input("Tal 2: ", s =>
            {
                double n = double.Parse(s);
                if (n == 0)
                {
                    throw new DivideByZeroException();
                }

                return n;
            });

            Console.WriteLine($"\n{((num1 % num2 == 0) ? "Talen är jämnt delbara." : "Talen är inte jämnt delbara.")}");
        }
    }
}