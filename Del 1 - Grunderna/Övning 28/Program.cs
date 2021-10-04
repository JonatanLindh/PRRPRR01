﻿#nullable enable
using System;
using Superclasses;

/*
 * Superclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Superclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_28
{
    class Program : MainSuperclass
    {
        static void Main(string[] args)
        {
            double depth = Input("Mönsterdjup (mm): ", double.Parse);
            string ans = (depth >= 1.6) ? "\nLagligt" : $"\n{1.6 - depth} mm saknas";
            Console.WriteLine(ans);
        }
    }
}