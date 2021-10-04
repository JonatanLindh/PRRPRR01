#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_18
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            int mult = Input("Multipel: ", int.Parse);
            
            Console.WriteLine();
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine(mult * i);
                i++;
            }
        }
    }
}