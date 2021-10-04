#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_35
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            int age = Input("Ålder: ", int.Parse);

            string ans = age switch
            {
                >= 0 and <= 12 => "Vit",
                >= 13 and <= 18 => "Grön",
                >= 19 and <= 25 => "Röd",
                >= 26 and <= 99 => "Blå",
                _ => "Ogiltig Ålder"
            };

            Console.WriteLine($"\n{ans}");
        }
    }
}