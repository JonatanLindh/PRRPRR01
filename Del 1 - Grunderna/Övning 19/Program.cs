﻿#nullable enable
using System;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_19
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            int start = Input("Sluttal: ", int.Parse);
            int stop = Input("Sluttal: ", int.Parse);
            
            for (int i = start; i <= stop; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}