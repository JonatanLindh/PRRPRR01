#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_27
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            int num1 = Input("Tal 1: ", int.Parse);
            int num2 = Input("Tal 2: ", int.Parse);

            string ans = (num1, num2) switch
            {
                _ when num1 == num2 => $"Talen är lika stora",
                _ when num1 < num2 => $"{num1} är minst",
                _ when num1 > num2 => $"{num2} är minst",
                _ => "???"
            };
            
            Console.WriteLine($"\n{ans}");
        }
    }
}