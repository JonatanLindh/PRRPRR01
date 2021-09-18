#nullable enable
using System;
using Subclasses;

/*
 * Subclasses innehåller classes som jag inheritar från
 * Detta är för att inte behöva upprepa kod
 * https://github.com/JonatanLindh/PRRPRR01/blob/master/Del%201%20-%20Grunderna/Subclasses/Class1.cs
 * Härifrån kommer t.ex Input metoden
 */

namespace Övning_32
{
    class Program : MainSubclass
    {
        static void Main(string[] args)
        {
            S1();
            S2();
            
            /*
             * S1 kommer bara kunna printa en av fallen
             * S2 kan printa alla fallen om flera stämmer, t.ex om tal = 120
             */
        }

        static void S1()
        {
            int tal = 11;
            if (tal > 1)
            {
                Console.WriteLine("Större än 1.");
            }
            else if (tal > 10)
            {
                Console.WriteLine("Större än 10.");
            }
            else if (tal > 100)
            {
                Console.WriteLine("Större än 100.");
            }
        }
        static void S2()
        {
            int tal = 11;
            if (tal > 1)
            {
                Console.WriteLine("Större än 1.");
            }
            if (tal > 10)
            {
                Console.WriteLine("Större än 10.");
            }
            if (tal > 100)
            {
                Console.WriteLine("Större än 100.");
            }
        }
    }
}