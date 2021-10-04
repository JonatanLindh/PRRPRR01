#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_9
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            int num1 = Input("Tal 1: ", int.Parse);
            int num2 = Input("Tal 2: ", int.Parse);
            int num3 = Input("Tal 3: ", int.Parse);

            Console.WriteLine($"\nSumma: {num1 + num2 + num3}");
            Console.WriteLine($"\nMedelvärde: {(num1 + num2 + num3)/3.0 :f2}");
        }
    }
}