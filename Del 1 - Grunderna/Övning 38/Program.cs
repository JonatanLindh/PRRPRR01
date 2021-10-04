#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */


namespace Övning_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1;

            Console.WriteLine("Ange ett tal");
            tal1 = int.Parse(Console.ReadLine());

            if(tal1 < 10)
            {
                Console.WriteLine("Ditt tal är mindre än 10");
            } 
            else if(tal1 > 10)
            {
                Console.WriteLine("Ditt tal är större än 10");
            }
        }
    }
}