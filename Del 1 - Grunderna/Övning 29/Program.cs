#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_29
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            string password = "hejhej";
            
            string attempt = Input("Lösenord: ", s => s);
            
            Console.WriteLine((attempt == password) ? "Rätt!" : "Fel :(");
        }
    }
}