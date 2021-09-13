#nullable enable
using System;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_12
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            int originalNum = Input("Tal: ", int.Parse);
            
            double num = (double) originalNum;
            num += 1;
            num *= 2;
            num -= 6;
            num /= 2;
            num += 3;
            num -= originalNum;

            Console.WriteLine($"\nNum (ska vara 1): {num}");
        }
    }
}