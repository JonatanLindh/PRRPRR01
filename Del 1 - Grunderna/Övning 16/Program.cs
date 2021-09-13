﻿#nullable enable
using System;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_16
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            int mult = Input("Multipel: ", int.Parse);
            
            Console.WriteLine();

            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine(mult * i);
            }
        }
    }
}