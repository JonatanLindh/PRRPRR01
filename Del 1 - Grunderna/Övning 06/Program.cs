#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_6
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            double degCelsius = Input("Grader i celsius: ", double.Parse);
            double degFahrenheit = 1.8 * degCelsius + 32;
            
            Console.WriteLine($"Grader i Fahrenheit: {degFahrenheit :f2} °F");
        }
    }
}