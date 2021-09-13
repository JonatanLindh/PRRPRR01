#nullable enable
using System;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_22
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            
            double balance = Input("Saldo på konto (kr): ", double.Parse);
            double interest = 1 + Input("Ränta (%): ", double.Parse) / 100.0;
            double goal = Input("Mål (kr): ", double.Parse);

            int years = (int) Math.Ceiling(Math.Log(goal / balance, interest));
            double finalBalance = balance * Math.Pow(interest, years);
            
            Console.WriteLine($"\nDet kommer att ta {years} år innan saldot når {finalBalance :f2}");
        }
    }
}